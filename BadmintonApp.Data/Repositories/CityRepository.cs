using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities.Location;

namespace BadmintonApp.Data.Repositories;

public class CityRepository : BaseRepository<CityDto, City>
{
	public CityDto? GetOrDefaultByName(string name)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Cities.SingleOrDefault(x => x.Name.ToLower() == name.Trim().ToLower());
		if (entity is null)
			return null;

		return Convert(entity);
	}

	public IEnumerable<CityDto> GetAllByRegionId(int regionId)
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Set<City>().Where(x => x.RegionId == regionId).ToArray();
		var dtos = entities.Select(Convert);
		return dtos;
	}

	protected override CityDto Convert(City entity) =>
		new()
		{
			Id = entity.Id,
			Name = entity.Name,
		};

	protected override City Convert(CityDto dto)
	{
		throw new NotImplementedException();
	}
}
