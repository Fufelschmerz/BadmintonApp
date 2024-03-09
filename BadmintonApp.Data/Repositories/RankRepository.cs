using Badminton.Contracts;
using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities.Players;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Data.Repositories;

public class RankRepository : BaseRepository<RankDto, Rank>
{
    public RankDto? GetOrDefaultByName(string title)
    {
        using var dbContext = new AppDbContext();
        var entity = dbContext.Ranks.SingleOrDefault(x => x.Title.ToLower() == title.Trim().ToLower());
        if (entity is null)
            return null;

        return Convert(entity);
    }

    public override IEnumerable<RankDto> GetAll()
    {
        using var dbContext = new AppDbContext();
        var entities = dbContext.Ranks
            .OrderBy(x => x.Id)
            .ToArray();
        var dtos = entities.Select(Convert);
        return dtos;
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