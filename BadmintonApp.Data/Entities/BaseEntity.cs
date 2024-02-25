using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities;

public abstract class BaseEntity
{
	[Key]
	public int Id { get; set; }

	public DateTime CreatedAtUTC { get; set; }

	public DateTime? UpdatedAtUTC { get; set; }
}