using BadmintonApp.Data.Entities.Matches.Enums;

namespace BadmintonApp.Data.Entities.Matches;

public class Set : BaseEntity
{
	public SetNumber Number { get; set; }

	public int MatchId { get; set; }

	public int ScorePlayerOne { get; set; }

	public int ScorePlayerTwo { get; set; }

	public Match Match { get; set; } = null!;
}