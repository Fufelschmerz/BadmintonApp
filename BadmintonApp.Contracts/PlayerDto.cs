using BadmintonApp.Contracts.Interfaces;

namespace Badminton.Contracts;

public class PlayerDto : IId
{
	public int? Id { get; set; }

	public string Name { get; set; } = null!;

	public string Surname { get; set; } = null!;

	public string Patronymic { get; set; } = null!;

	public int? RankId { get; set; }

	public string? RankTitle { get; set; }

	public string Genger { get; set; } = null!;

	public DateTime DateBirthday { get; set; }
}
