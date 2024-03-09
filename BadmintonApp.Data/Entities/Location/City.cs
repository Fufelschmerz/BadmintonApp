namespace BadmintonApp.Data.Entities.Location;

public class City : BaseEntity
{
	public string Name { get; set; } = null!;

	public int RegionId { get; set; }

	public Region Region { get; set; } = null!;
}
