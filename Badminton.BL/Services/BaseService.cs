using BadmintonApp.Contracts.Interfaces;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public abstract class BaseService<TRepository, TDto, TEntity>
	where TRepository : BaseRepository<TDto, TEntity>
	where TDto : class, IId
	where TEntity : BaseEntity
{
	protected readonly TRepository _repository;

    protected BaseService(TRepository repository)
    {
		_repository = repository;
    }

    public virtual void InsertOrUpdate(TDto dto)
	{
		if (dto.Id is not null)
		{
			_repository.Update(dto);
			return;
		}

		_repository.Insert(dto);
	}

	public virtual IEnumerable<TDto> GetAll() =>
		_repository.GetAll();
}
