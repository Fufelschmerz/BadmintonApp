using BadmintonApp.Contracts.Interfaces;
using BadmintonApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BadmintonApp.Data.Repositories;

public abstract class BaseRepository<TDto, TEntity>
	where TDto : class, IId
	where TEntity : BaseEntity
{
	public virtual void Insert(TDto dto)
	{
		using var dbContext = new AppDbContext();
		var entity = Convert(dto);
		dbContext.Set<TEntity>().Add(entity);
		dbContext.SaveChanges();
	}

	public virtual void Update(TDto dto)
	{
		using var dbContext = new AppDbContext();

		if (dto.Id.HasValue)
		{
			bool isExistsEntity = dbContext.Set<TEntity>()
				.Any(x => x.Id == dto.Id);

			if (!isExistsEntity)
				throw new ArgumentException("Не удалось обновить запись", nameof(dto.Id));

			var entity = Convert(dto);
			var entry = dbContext.Set<TEntity>().Update(entity);
			dbContext.SaveChanges();
		}
	}

	public virtual IEnumerable<TDto> GetAll()
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Set<TEntity>().ToArray();

		return entities.Select(Convert);
	}

	public virtual TDto? GetOrDefaultById(int id)
	{
		using var dbContext = new AppDbContext();
		var entity = dbContext.Set<TEntity>().SingleOrDefault(x => x.Id == id);

		if (entity is null)
			return default;

		return Convert(entity);
	}

	public virtual void DeleteRange(IEnumerable<int> ids)
	{
		using var dbContext = new AppDbContext();
		var entities = dbContext.Set<TEntity>().Where(x => ids.Contains(x.Id));
		dbContext.RemoveRange(entities);
		dbContext.SaveChanges();
	}

	protected abstract TDto Convert(TEntity entity);

	protected abstract TEntity Convert(TDto dto);
}