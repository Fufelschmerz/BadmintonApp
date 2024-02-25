using BadmintonApp.Contracts.Interfaces;

namespace BadmintonApp.Contracts;

public class RankDto : IId
{
	public int? Id { get; set; }

	public string Title { get; set; } = null!;
}
