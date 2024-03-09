namespace BadmintonApp.Contracts.Models;

public class GetPlayersModel
{
	public string? CityName { get; set; }

	public string? Gender { get; set; } 

	public string? RankTitle { get; set; }

	public int? YearBirthday { get; set; }
}
