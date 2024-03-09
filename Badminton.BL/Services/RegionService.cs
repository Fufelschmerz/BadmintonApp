using BadmintonApp.Contracts;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class RegionService
{
	private readonly RegionRepository _regionRepository = new();

	public IEnumerable<RegionDto> GetAll() =>
		_regionRepository.GetAll();
}
