using BadmintonApp.Data.Entities.Location;
using BadmintonApp.Data.Entities.Players;

namespace BadmintonApp.Data.Entities;

public class Tournament : BaseEntity
{
	public string Title { get; set; } = null!;

	public DateTime DateStart { get; set; }

	public DateTime DateEnd { get; set; }

	public int CityId { get; set; }

	public City City { get; set; } = null!;

	public ICollection<Category>? Categories { get; set; }

	public ICollection<Player>? Players { get; set; }
}