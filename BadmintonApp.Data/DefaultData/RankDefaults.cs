using BadmintonApp.Data.DefaultData.Interfaces;
using BadmintonApp.Data.Entities.Players;

namespace BadmintonApp.Data.DefaultData;

public class RankDefaults : IDefaultData<Rank>
{
	public IEnumerable<Rank> GetDefaultsData() =>
		new Rank[]
		{
			new Rank
			{
				Id = 1,
				Title = "МСМК",
				CreatedAtUTC = DateTime.UtcNow,
			},
			new Rank
			{
				Id = 2,
				Title = "МС",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 3,
				Title = "КМС",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 4,
				Title = "1",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 5,
				Title = "2",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 6,
				Title = "3",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 7,
				Title = "1ю",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 8,
				Title = "2ю",
				CreatedAtUTC= DateTime.UtcNow,
			},
			new Rank
			{
				Id = 9,
				Title = "3ю",
				CreatedAtUTC= DateTime.UtcNow,
			},
		};
}
