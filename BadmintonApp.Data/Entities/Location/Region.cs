using System.ComponentModel.DataAnnotations;

namespace BadmintonApp.Data.Entities.Location;

public class Region : BaseEntity
{
	[MaxLength(255)]
	public string Name { get; set; } = null!;

	public int CountryId { get; set; }

	public Country Country { get; set; } = null!;

	public ICollection<City> Cities { get; set; } = null!;
}
