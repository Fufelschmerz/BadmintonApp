using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities;

public class Category : BaseEntity
{
	public const int SingleCategoryId = 1;
	public const int DoublesCategoryId = 2;
	public const int MixedCategoryId = 3;

	[MaxLength(255)]
	public string Title { get; set; } = null!;

	public ICollection<Tournament>? Tournaments { get; set; }
}