using Badminton.BL.Services;
using Badminton.Contracts;
using BadmintonApp.Contracts.Models;
using BadmintonApp.Data.Repositories;

namespace BadmintonApp.Desktop.Forms;
public partial class AddPlayersToTournament : Form
{
	private readonly TournamentService _tournamentService;
	private readonly PlayerService _playerService;
	private readonly RankService _rankService;
	private readonly CityService _cityService;

	public AddPlayersToTournament()
	{
		var tournamentRepository = new TournamentRepository();
		_tournamentService = new TournamentService(tournamentRepository);

		var playerRepository = new PlayerRepository();
		_playerService = new PlayerService(playerRepository);

		var rankRepository = new RankRepository();
		_rankService = new RankService(rankRepository);

		_cityService = new CityService();

		InitializeComponent();
		InitializeComboBoxTournaments();
		InitializeFilters();
		InitializePlayersDataGridView();
	}

	private void InitializeComboBoxTournaments()
	{
		var tournaments = _tournamentService.GetAll();

		var tournamentTitles = tournaments.Select(x => x.Title).ToArray();

		TournamentsComboBox.Items.AddRange(tournamentTitles);
		TournamentsComboBox.SelectedIndex = 0;
	}

	private void InitializeFilters()
	{
		for (int i = 1960; i <= DateTime.UtcNow.Year; i++)
			FilterByYearBirthday.Items.Add(i);

		var cities = _cityService.GetAll();
		var ranks = _rankService.GetAll();

		foreach (var city in cities)
			FilterByCity.Items.Add(city.Name);

		foreach (var rank in ranks)
			FilterByRank.Items.Add(rank.Title);
	}

	private void InitializePlayersDataGridView()
	{
		PlayersDataGridView.Rows.Clear();

		var filterParameters = new GetPlayersModel
		{
			CityName = FilterByCity.SelectedItem as string,
			Gender = FilterByGender.SelectedItem as string,
			YearBirthday = FilterByYearBirthday.SelectedItem as int?,
			RankTitle = FilterByRank.SelectedItem as string
		};

		var players = _playerService.GetAllByFilters(filterParameters);

		var tournamentTitle = TournamentsComboBox.SelectedItem as string;

		if (tournamentTitle is null)
		{
			AddPlayers(Enumerable.Empty<PlayerDto>());
			return;
		}

		var tournament = _tournamentService.GetOrDefaultByTitle(tournamentTitle);

		if (tournament is null)
			throw new ArgumentNullException(nameof(tournament));

		if (tournament.Players is null)
		{
			AddPlayers(Enumerable.Empty<PlayerDto>());
			return;
		}

		AddPlayers(tournament.Players);

		void AddPlayers(IEnumerable<PlayerDto> addedPlayers)
		{
			foreach (var player in players)
			{
				var isAddedPlayer = addedPlayers.Any(x => x.Id == player.Id);

				PlayersDataGridView.Rows.Add(player.Id,
					player.Surname,
					player.Name,
					player.Patronymic,
					player.DateBirthday.ToString("d"),
					player.Genger,
					player.City?.Name,
					player.RankTitle,
					isAddedPlayer);
			}
		}
	}

	private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
	{
		InitializePlayersDataGridView();
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		var tournamentTitle = TournamentsComboBox.SelectedItem as string;

		if (tournamentTitle is null)
			throw new ArgumentNullException("Турнир не выбран");

		var selectedPlayerIds = new List<int>();

		for (int i = 0; i < PlayersDataGridView.Rows.Count; i++)
		{
			var row = PlayersDataGridView.Rows[i];

			if (row.Cells["IsAddPlayer"].Value is true)
			{
				var playerId = (int)row.Cells["Id"].Value;
				selectedPlayerIds.Add(playerId);
			}
		}

		var players = new List<PlayerDto>();

		foreach (var playerId in selectedPlayerIds)
		{
			var player = _playerService.GetOrDefaultByIdAsync(playerId);

			if (player is not null)
				players.Add(player);
		}

		_tournamentService.AddPlayersToTournament(tournamentTitle, players);

		InitializePlayersDataGridView();
	}

	private void ClearFilters_Click(object sender, EventArgs e)
	{
		FilterByCity.SelectedItem = null;
		FilterByGender.SelectedItem = null;
		FilterByYearBirthday.SelectedItem = null;
		FilterByRank.SelectedItem = null;
	}
}
