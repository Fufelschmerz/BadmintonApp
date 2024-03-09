using BadmintonApp.Data.DefaultData.Interfaces;
using BadmintonApp.Data.Entities.Location;

namespace BadmintonApp.Data.DefaultData;
public class RegionDefaults : IDefaultData<Region>
{
	public IEnumerable<Region> GetDefaultsData() =>
		new[]
		{
			new Region
			{
				Id = 1,
				CreatedAtUTC = DateTime.UtcNow,
				Name = "Пермский край",
				CountryId = 1,
			}
		};
}
