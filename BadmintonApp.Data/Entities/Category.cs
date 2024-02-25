using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities;

public class Category : BaseEntity
{
	[MaxLength(255)]
	public string Title { get; set; } = null!;
}