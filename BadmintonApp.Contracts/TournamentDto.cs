using Badminton.Contracts;
using BadmintonApp.Contracts.Interfaces;

namespace BadmintonApp.Contracts;

public class TournamentDto : IId
{
	public int? Id { get; set; }

	public string Title { get; set; } = null!;

	public DateTime DateStart { get; set; }

	public DateTime DateEnd { get; set; }

	public int CityId { get; set; }

	public CityDto? City { get; set; }

	public IEnumerable<CategoryDto>? Categories { get; set; }

	public IEnumerable<PlayerDto>? Players { get; set; }
}