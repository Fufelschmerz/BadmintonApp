using Badminton.BL.Services;
using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Repositories;

namespace BadmintonApp.Desktop.Forms;

public partial class TournamentForm : Form
{
	private readonly CityService _cityService = new();
	private readonly TournamentService _tournamentService;
	private readonly CategoryService _categoryService;

	public TournamentForm()
	{
		TournamentRepository tournamentRepository = new();
		CategoryRepository categoryRepository = new();
		_tournamentService = new(tournamentRepository);
		_categoryService = new(categoryRepository);

		InitializeComponent();
		InitializeLocationComboBoxes();
		InitializeDataGridView();
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
		TournamentDataGridView.Columns.Insert(4, cityColumn);
	}

	private void InitializeDataGridView()
	{
		TournamentDataGridView.Rows.Clear();
		var tournaments = _tournamentService.GetAll();

		foreach (var tournament in tournaments)
		{
			var isSelectedSingleCategory = tournament.Categories?.Any(x => x.Id == Category.SingleCategoryId);

			var isSelectedDoublesCategory = tournament.Categories?.Any(x => x.Id == Category.DoublesCategoryId);

			var isMixedCategory = tournament.Categories?.Any(x => x.Id == Category.MixedCategoryId);

			TournamentDataGridView.Rows.Add(tournament.Id,
				tournament.Title,
				tournament.DateStart,
				tournament.DateEnd,
				tournament.City?.Name,
				isSelectedSingleCategory,
				isSelectedDoublesCategory,
				isMixedCategory);
		}
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < TournamentDataGridView.Rows.Count - 1; i++)
		{
			var row = TournamentDataGridView.Rows[i];

			var dto = BuildDto(row);

			_tournamentService.InsertOrUpdate(dto);
		}
	}

	private TournamentDto BuildDto(DataGridViewRow row)
	{
		ValidateRow(row);

		int? id = row.Cells[0].Value as int?;
		string title = (string)row.Cells[1].Value;
		DateTime dateStart = DateTime.Parse(row.Cells[2].Value.ToString()!);
		DateTime dateEnd = DateTime.Parse(row.Cells[3].Value.ToString()!);
		string cityName = (string)row.Cells[4].Value;
		bool? isAddSingleCategory = row.Cells[5].Value as bool?;
		bool? isAddDoublesCategory = row.Cells[6].Value as bool?;
		bool? isAddMixedCategory = row.Cells[7].Value as bool?;

		CityDto? city = _cityService.GetOrDefaultByName(cityName);

		if (city is null)
			throw new ArgumentNullException(nameof(city));

		var categoryIds = new List<int>();

		if (isAddSingleCategory is true)
			categoryIds.Add(1);

		if (isAddDoublesCategory is true)
			categoryIds.Add(2);

		if (isAddMixedCategory is true)
			categoryIds.Add(3);

		var categories = new List<CategoryDto>();

		foreach (var categoryId in categoryIds)
		{
			var category = _categoryService.GetOrDefaultById(categoryId);

			if (category is null)
				throw new ArgumentNullException(nameof(category));

			categories.Add(category);
		}

		return new TournamentDto
		{
			Id = id,
			Title = title,
			DateStart = dateStart,
			DateEnd = dateEnd,
			CityId = city.Id!.Value,
			Categories = categories,
		};
	}

	private static void ValidateRow(DataGridViewRow row)
	{
		int index = row.Index + 1;

		if (row.Cells[1].Value is null)
			throw new ArgumentNullException($"В строке {index} не указано название");

		if (!DateTime.TryParse(row.Cells[2].Value.ToString(), out var dateStart))
			throw new ArgumentNullException($"В строке {row.Index} указана некорректная дата начала");

		if (!DateTime.TryParse(row.Cells[3].Value.ToString(), out var dateEnd))
			throw new ArgumentNullException($"В строке {row.Index} указана некорректная дата начала");

		if (dateStart > dateEnd)
			throw new ArgumentException("Дата начала турнира не может превышать дату окончания турнира");

		if (row.Cells[4].Value is null)
			throw new ArgumentNullException($"В строке {index} не указан город игрока");
	}

	private void AddPlayers_Click(object sender, EventArgs e)
	{
		var addingplayersForm = new AddPlayersToTournament();

		addingplayersForm.ShowDialog();
	}
}
