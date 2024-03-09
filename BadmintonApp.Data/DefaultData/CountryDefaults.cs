using BadmintonApp.Data.DefaultData.Interfaces;
using BadmintonApp.Data.Entities.Location;

namespace BadmintonApp.Data.DefaultData.Location;

public class CountryDefaults : IDefaultData<Country>
{
	public IEnumerable<Country> GetDefaultsData() =>
		new Country[]
		{
			new Country
			{
				Id = 1,
				CreatedAtUTC = DateTime.UtcNow,
				Name = "Россия"
			}
		};
}
