using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities.Location;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Data.Repositories;

public class RegionRepository : BaseRepository<RegionDto, Region>
{
	public RegionDto? GetOrDefaultByName(string name)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Regions.SingleOrDefault(x => x.Name.ToLower() == name.Trim().ToLower());
		if (entity is null)
			return null;

		return Convert(entity);
	}

	public override IEnumerable<RegionDto> GetAll()
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Regions.Include(x => x.Cities).ToArray();
		var dtos = entities.Select(Convert);

		return dtos;
	}

	protected override RegionDto Convert(Region entity) =>
		new()
		{
			Id = entity.Id,
			Name = entity.Name,
			Cities = entity.Cities?.Select(x => new CityDto
			{
				Id = x.Id,
				Name = x.Name,
			})
		};

	protected override Region Convert(RegionDto dto)
	{
		throw new NotImplementedException();
	}
}