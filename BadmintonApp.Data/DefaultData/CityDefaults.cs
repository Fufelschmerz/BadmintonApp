using BadmintonApp.Data.DefaultData.Interfaces;
using BadmintonApp.Data.Entities.Location;

namespace BadmintonApp.Data.DefaultData;

public class CityDefaults : IDefaultData<City>
{
	public IEnumerable<City> GetDefaultsData() =>
		new[]
		{
			new City
			{
				Id = 1,
				CreatedAtUTC = DateTime.UtcNow,
				Name = "Пермь",
				RegionId = 1,
			},
			new City
			{
				Id = 2,
				CreatedAtUTC = DateTime.UtcNow,
				Name = "Березники",
				RegionId = 1,
			}
		};
}
