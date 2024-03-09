using System.ComponentModel.DataAnnotations;
using BadmintonApp.Data.Entities.Location;
using BadmintonApp.Data.Entities.Matches;

namespace BadmintonApp.Data.Entities.Players;

public class Player : BaseEntity
{
	[MaxLength(255)]
	public string Name { get; set; } = null!;

	[MaxLength(255)]
	public string Surname { get; set; } = null!;

	[MaxLength(255)]
	public string Patronymic { get; set; } = null!;

	public int CityId { get; set; }

	public int? RankId { get; set; }

	public DateTime DateBirthday { get; set; }

	public string Genger { get; set; }

	public Rank? Rank { get; set; }

	public City City { get; set; } = null!;

	public ICollection<Tournament>? Tournaments { get; set; }

	public ICollection<Match> HomeMatches { get; set; } = Array.Empty<Match>();

	public ICollection<Match> AwayMatches { get; set; } = Array.Empty<Match>();
}
