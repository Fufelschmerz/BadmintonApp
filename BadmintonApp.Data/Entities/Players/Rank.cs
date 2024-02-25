using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities.Players;

public class Rank : BaseEntity
{
	[MaxLength(255)]
	public string Title { get; set; } = null!;
}