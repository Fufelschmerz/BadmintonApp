using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities.Location;

public class Country : BaseEntity
{
	[MaxLength(255)]
	public string Name { get; set; } = null!;

	public ICollection<Region> Regions { get; set; } = null!;
}
