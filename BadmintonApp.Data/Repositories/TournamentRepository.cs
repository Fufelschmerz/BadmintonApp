using Badminton.Contracts;
using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Entities.Location;
using BadmintonApp.Data.Entities.Players;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Data.Repositories;

public class TournamentRepository : BaseRepository<TournamentDto, Tournament>
{
	public override void Insert(TournamentDto dto)
	{
		using var dbContext = new AppDbContext();
		IEnumerable<int> categoryIds = dto.Categories.Select(c => c.Id!.Value);
		var categories = dbContext.Categories.Where(x => categoryIds.Contains(x.Id)).ToArray();
		var entity = Convert(dto);
		entity.Categories = categories;

		dbContext.Tournaments.Add(entity);
		dbContext.SaveChanges();
	}

	public override void Update(TournamentDto dto)
	{
		using var dbContext = new AppDbContext();

		if (dto.Id.HasValue)
		{
			var existingEntity = dbContext.Tournaments
				.Include(x => x.Categories)
				.Include(x => x.Players)
				.SingleOrDefault(x => x.Id == dto.Id);

			if (existingEntity is null)
				throw new ArgumentException("Не удалось обновить запись", nameof(dto.Id));

			existingEntity.Categories?.Clear();
			existingEntity.Players?.Clear();
			dbContext.Tournaments.Update(existingEntity);
			dbContext.SaveChanges();
			dbContext.ChangeTracker.Clear();

			var entity = Convert(dto);
			dbContext.Tournaments.Update(entity);
			dbContext.SaveChanges();
		}
	}

	public TournamentDto? GetOrDefaultByTitle(string name)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Tournaments
			.Include(t => t.Categories)
			.Include(t => t.Players)
			.SingleOrDefault(x => x.Title.ToLower() == name.Trim().ToLower());
		if (entity is null)
			return null;

		return Convert(entity);
	}

	public override IEnumerable<TournamentDto> GetAll()
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Tournaments
			.Include(x => x.City)
			.Include(x => x.Categories)
			.ToArray();

		return entities.Select(Convert);
	}

	protected override TournamentDto Convert(Tournament entity)
	{
		var dto = new TournamentDto()
		{
			Id = entity.Id,
			Title = entity.Title,
			DateStart = entity.DateStart,
			DateEnd = entity.DateEnd,
			CityId = entity.CityId,
		};

		if(entity.City is not null)
		{
			dto.City = new CityDto
			{
				Id = entity.City.Id,
				Name = entity.City.Name,
			};
		}

		if(entity.Categories is not null)
		{
			dto.Categories = entity.Categories?.Select(c => new CategoryDto
			{
				Id = c.Id,
				Title = c.Title
			});
		}

		if(entity.Players is not null)
		{
			dto.Players = entity.Players?.Select(p => new PlayerDto
			{
				Id = p.Id,
				Name = p.Name,
				Surname = p.Surname,
				Patronymic = p.Patronymic,
				City = new CityDto 
				{
					Id = p.City?.Id,
					Name = p.City?.Name,
				},
				RankTitle = p.Rank?.Title,
				DateBirthday = p.DateBirthday,
			});
		}

		return dto;
	}

	protected override Tournament Convert(TournamentDto dto)
		=> new()
		{
			Id = dto.Id ?? 0,
			Title = dto.Title,
			DateStart = dto.DateStart.ToUniversalTime(),
			DateEnd = dto.DateEnd.ToUniversalTime(),
			CityId = dto.CityId,
			Categories = dto.Categories?.Select(c => new Category
			{
				Id = c.Id ?? 0,
				Title = c.Title
			}).ToArray(),
			Players = dto.Players?.Select(p => new Player
			{
				Id = p.Id ?? 0,
				Name = p.Name,
				Surname = p.Surname,
				Patronymic = p.Patronymic,
				RankId = p.RankId,
				CityId = p.CityId,
				Genger = p.Genger,
				DateBirthday = p.DateBirthday.ToUniversalTime(),
			}).ToArray(),
		};
}
