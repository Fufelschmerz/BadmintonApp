using Badminton.BL.Services;
using Badminton.Contracts;
using BadmintonApp.Data.Repositories;

namespace BadmintonApp.Desktop.Forms;
public partial class PlayersForm : Form
{
	//TODO: избавиться от использования репозиториев, использовать сервисы
	private readonly RankRepository _rankRepository = new();
	private readonly PlayerService _playerService = new();

	public PlayersForm()
	{
		InitializeComponent();
		InitializeComboBoxRanks();
		InitializeDataGridView();
	}

	private void InitializeDataGridView()
	{
		PlayersDataGridView.Rows.Clear();

		var players = _playerService.GetAll();

		foreach (var player in players)
		{
			PlayersDataGridView.Rows.Add(player.Id,
				player.Surname,
				player.Name,
				player.Patronymic,
				player.DateBirthday.ToString("d"),
				player.Genger,
				player.RankTitle);
		}
	}

	private void InitializeComboBoxRanks()
	{
		var ranks = _rankRepository.GetAll()
			.Select(x => x.Title);

		var rankColumn = new DataGridViewComboBoxColumn()
		{
			Name = "Rank",
			HeaderText = "Разряды"
		};

		foreach (string? rank in ranks)
			rankColumn.Items.Add(rank);

		PlayersDataGridView.Columns.Insert(6, rankColumn);
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		var idsToDelete = GetRecordsToDelete();

		if (idsToDelete.Any())
			_playerService.DeleteRange(idsToDelete);

		for (int i = 0; i < PlayersDataGridView.Rows.Count - 1; i++)
		{
			var row = PlayersDataGridView.Rows[i];

			ValidateRow(row);

			var dto = BuildDto(row);

			_playerService.InsertOrUpdate(dto);
		}

		InitializeDataGridView();
	}

	private IEnumerable<int> GetRecordsToDelete()
	{
		var ids = new List<int>();

		foreach (DataGridViewRow row in PlayersDataGridView.Rows)
		{
			int? id = row.Cells[0].Value as int?;

			if (id.HasValue)
				ids.Add(id.Value);
		}

		var existsIds = _playerService.GetAll().Select(x => x.Id!.Value);

		return existsIds.Where(x => !ids.Contains(x));
	}

	private PlayerDto BuildDto(DataGridViewRow row)
	{
		int? id = row.Cells[0].Value as int?;
		string surname = (string)row.Cells[1].Value;
		string name = (string)row.Cells[2].Value;
		string patronymic = (string)row.Cells[3].Value;
		var dateBirthday = DateTime.Parse(row.Cells[4].Value.ToString()!);
		string gender = (string)row.Cells[5].Value;
		string? rankName = row.Cells[6].Value as string;

		int? rankId = null;

		if (rankName is not null)
		{
			var rank = _rankRepository.GetOrDefaultByName(rankName);

			if (rank is null)
				throw new ArgumentNullException(nameof(rank));

			rankId = rank.Id;
		}

		return new PlayerDto
		{
			Id = id,
			Name = name,
			Surname = surname,
			Patronymic = patronymic,
			DateBirthday = dateBirthday.ToUniversalTime(),
			Genger = gender,
			RankId = rankId,
		};
	}

	private static void ValidateRow(DataGridViewRow row)
	{
		int index = row.Index + 1;

		if (row.Cells[1].Value is null)
			throw new ArgumentNullException($"В строке {index} не указана фамилия игрока");

		if (row.Cells[2].Value is null)
			throw new ArgumentNullException($"В строке {index} не указано имя игрока");

		if (row.Cells[3].Value is null)
			throw new ArgumentNullException($"В строке {index} не указано отчество игрока");

		if (row.Cells[4].Value is null)
			throw new ArgumentNullException($"В строке {index} не указана дата рождения игрока");

		if (!DateTime.TryParse(row.Cells[4].Value.ToString(), out var _))
			throw new ArgumentNullException($"В строке {row.Index + 1} указана некорректная дата");

		if (row.Cells[5].Value is null)
			throw new ArgumentNullException($"В строке {index} не указан пол игрока");
	}
}
