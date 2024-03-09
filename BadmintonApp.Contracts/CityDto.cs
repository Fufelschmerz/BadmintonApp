using BadmintonApp.Contracts.Interfaces;

namespace BadmintonApp.Contracts;

public class CityDto : IId
{
	public int? Id { get; set; }

	public string Name { get; set; } = null!;
}