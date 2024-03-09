using BadmintonApp.Data.DefaultData.Interfaces;
using BadmintonApp.Data.Entities;

namespace BadmintonApp.Data.DefaultData;

public class CategoryDefaults : IDefaultData<Category>
{
	public IEnumerable<Category> GetDefaultsData() =>
		new[]
		{
			new Category
			{
				Id = 1,
				CreatedAtUTC = DateTime.UtcNow,
				Title = "Одиночный разряд",
			},
			new Category
			{
				Id = 2,
				CreatedAtUTC = DateTime.UtcNow,
				Title = "Парный разряд",
			},
			new Category
			{
				Id = 3,
				CreatedAtUTC = DateTime.UtcNow,
				Title = "Смешанный",
			}
		};
}
