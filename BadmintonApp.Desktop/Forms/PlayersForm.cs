using Badminton.BL.Services;
using Badminton.Contracts;
using BadmintonApp.Data.Repositories;

namespace BadmintonApp.Desktop.Forms;

//TODO: разобраться с регионом и городами
public partial class PlayersForm : Form
{
	private readonly CityService _cityService = new();

	private readonly PlayerService _playerService;
	private readonly RankService _rankService;

	public PlayersForm()
	{
		var playerRepository = new PlayerRepository();
		var rankRepository = new RankRepository();
		_playerService = new PlayerService(playerRepository);
		_rankService = new RankService(rankRepository);

		InitializeComponent();
		InitializeComboBoxRank();
		InitializeLocationComboBoxes();
		InitializeDataGridView();

		//PlayersDataGridView.EditingControlShowing += PlayersDataGridView_EditingControlShowing;
	}

	//private void PlayersDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
	//{
	//	if (PlayersDataGridView.CurrentCell.ColumnIndex == 7 && e.Control is ComboBox)
	//	{
	//		var comboBox = e.Control as ComboBox;

	//		if (comboBox is not null)
	//		{
	//			//var regionName = comboBox.SelectedValue?.ToString();

	//			_citites = _cityService.GetAllByRegion("Пермский край");

	//			comboBox.SelectedIndexChanged += RegionSelectionChanged;
	//		}
	//	}
	//}

	//private void RegionSelectionChanged(object sender, EventArgs e)
	//{
	//	var currentCell = PlayersDataGridView.CurrentCellAddress;
	//	var cityCell = (DataGridViewComboBoxCell)PlayersDataGridView.Rows[currentCell.Y].Cells[8];

	//	//TODO: заполняем
	//	foreach(var city in _citites)
	//		cityCell.Items.Add(city.Name);
	//}

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
				player.RankTitle,
				player.City?.Name);
		}
	}

	private void InitializeLocationComboBoxes()
	{
		//var regions = _regionService.GetAll();
		var cities = _cityService.GetAllByRegion("Пермский край");

		//var regionColumn = new DataGridViewComboBoxColumn()
		//{
		//	Name = "Region",
		//	HeaderText = "Регион"
		//};

		//foreach (var region in regions)
		//	regionColumn.Items.Add(region.Name);

		var cityColumn = new DataGridViewComboBoxColumn()
		{
			Name = "City",
			HeaderText = "Город"
		};

		foreach (var city in cities)
			cityColumn.Items.Add(city.Name);

		//PlayersDataGridView.Columns.Insert(7, regionColumn);
		PlayersDataGridView.Columns.Insert(7, cityColumn);
	}

	private void InitializeComboBoxRank()
	{
		var ranks = _rankService.GetAll()
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
		ValidateRow(row);

		int? id = row.Cells[0].Value as int?;
		string surname = (string)row.Cells[1].Value;
		string name = (string)row.Cells[2].Value;
		string patronymic = (string)row.Cells[3].Value;
		var dateBirthday = DateTime.Parse(row.Cells[4].Value.ToString()!);
		string gender = (string)row.Cells[5].Value;
		string? rankName = row.Cells[6].Value as string;
		string cityName = (string)row.Cells[7].Value;

		int? rankId = null;
		int cityId = 0;

		if (rankName is not null)
		{
			var rank = _rankService.GetOrDefaultByName(rankName);

			if (rank is null)
				throw new ArgumentNullException(nameof(rank));

			rankId = rank.Id;
		}

		if (cityName is not null)
		{
			var city = _cityService.GetOrDefaultByName(cityName);

			if (city is null)
				throw new ArgumentNullException(nameof(city));

			cityId = city.Id!.Value;
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
			CityId = cityId,
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
			throw new ArgumentNullException($"В строке {row.Index} указана некорректная дата");

		if (row.Cells[5].Value is null)
			throw new ArgumentNullException($"В строке {index} не указан пол игрока");

		if (row.Cells[7].Value is null)
			throw new ArgumentNullException($"В строке {index} не указан город за который выступает игрок");
	}
}
