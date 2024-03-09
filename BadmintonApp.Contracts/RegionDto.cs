using BadmintonApp.Contracts.Interfaces;

namespace BadmintonApp.Contracts;

public class RegionDto : IId
{
	public int? Id { get; set; }

	public string Name { get; set; } = null!;

	public IEnumerable<CityDto>? Cities { get; set; }
}
