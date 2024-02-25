using BadmintonApp.Data.Entities.Players;

namespace BadmintonApp.Data.Entities.Matches;

public class Match : BaseEntity
{
	public int PlayerOneId { get; set; }

	public int PlayerTwoId { get; set; }

	public Player PlayerOne { get; set; } = null!;

	public Player PlayerTwo { get; set; } = null!;

	public ICollection<Set> Sets { get; set; } = Array.Empty<Set>();
}