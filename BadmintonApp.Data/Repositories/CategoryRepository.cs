using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities;

namespace BadmintonApp.Data.Repositories;

public class CategoryRepository : BaseRepository<CategoryDto, Category>
{
	protected override CategoryDto Convert(Category entity) =>
		new()
		{
			Id = entity.Id,
			Title = entity.Title,
		};

	protected override Category Convert(CategoryDto dto)
	{
		throw new NotImplementedException();
	}
}
