using BadmintonApp.Contracts;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class CityService
{
	private readonly CityRepository _cityRepository = new();
	private readonly RegionRepository _regionRepository = new();

	public CityDto? GetOrDefaultByName(string name) =>
		_cityRepository.GetOrDefaultByName(name);

	public IEnumerable<CityDto> GetAllByRegion(string regionName)
	{
		var region = _regionRepository.GetOrDefaultByName(regionName);

		if(region is null)
			return Enumerable.Empty<CityDto>();

		return _cityRepository.GetAllByRegionId(region.Id!.Value);
	}

	public IEnumerable<CityDto> GetAll() =>
		_cityRepository.GetAll();
}
