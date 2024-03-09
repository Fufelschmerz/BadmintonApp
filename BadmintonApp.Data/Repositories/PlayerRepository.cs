using Badminton.Contracts;
using BadmintonApp.Contracts;
using BadmintonApp.Contracts.Models;
using BadmintonApp.Data.Entities.Players;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Data.Repositories;

public class PlayerRepository : BaseRepository<PlayerDto, Player>
{
	public override IEnumerable<PlayerDto> GetAll()
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Players
			.Include(x => x.Rank)
			.Include(x => x.City)
			.OrderBy(x => x.Id)
			.ToArray();
		var dtos = entities.Select(Convert);
		return dtos;
	}


	public IEnumerable<PlayerDto> GetAllByFilters(GetPlayersModel parameters)
	{
		using var dbContext = new AppDbContext();
		
		var query = dbContext.Players
			.Include(x => x.Rank)
			.Include(x => x.City)
			.AsNoTracking()
			.ToArray();

		if (parameters.CityName is not null)
			query = query.Where(x => x.City.Name == parameters.CityName).ToArray();

		if (parameters.Gender is not null)
			query = query.Where(x => x.Genger == parameters.Gender).ToArray();

		if (parameters.YearBirthday is not null)
			query = query.Where(x => x.DateBirthday.Year == parameters.YearBirthday).ToArray();

		if (parameters.RankTitle is not null)
			query = query.Where(x => x.Rank?.Title == parameters.RankTitle).ToArray();

		var entities = query.OrderBy(x => x.Id);
		var dtos = query.Select(Convert);
		return dtos;
	}

	public override PlayerDto? GetOrDefaultById(int id)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Players
			.Include(x => x.Rank)
			.SingleOrDefault(x => x.Id == id);

		if (entity is null)
			return null;

		return Convert(entity);
	}

	protected override PlayerDto Convert(Player entity)
	{
		const int timeOffsetUTC = 5;

		return new PlayerDto
		{
			Id = entity.Id,
			Name = entity.Name,
			Surname = entity.Surname,
			Patronymic = entity.Patronymic,
			RankId = entity.RankId,
			RankTitle = entity.Rank?.Title,
			Genger = entity.Genger,
			DateBirthday = entity.DateBirthday.AddHours(timeOffsetUTC),
			CityId = entity.CityId,
			City = new CityDto
			{
				Id = entity.City?.Id,
				Name = entity.City?.Name,
			}
		};
	}

	protected override Player Convert(PlayerDto dto)
	{
		return new Player
		{
			Id = dto.Id ?? 0,
			Name = dto.Name,
			Surname = dto.Surname,
			Patronymic = dto.Patronymic,
			RankId = dto.RankId,
			CityId = dto.CityId,
			Genger = dto.Genger,
			DateBirthday = dto.DateBirthday.ToUniversalTime(),
		};
	}
}