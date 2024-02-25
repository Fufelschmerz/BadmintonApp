using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities.Players;

namespace BadmintonApp.Data.Repositories;

public class RankRepository : BaseRepository<RankDto, Rank>
{
	public RankDto? GetOrDefaultByName(string name)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Ranks.SingleOrDefault(x => x.Title.ToLower() == name.Trim().ToLower());
		if (entity is null)
			return null;

		return Convert(entity);
	}

	protected override RankDto Convert(Rank entity)
	{
		return new RankDto
		{
			Id = entity.Id,
			Title = entity.Title,
		};
	}

	protected override Rank Convert(RankDto dto)
	{
		return new Rank
		{
			Title = dto.Title,
		};
	}
}