using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class CategoryService : BaseService<CategoryRepository, CategoryDto, Category>
{
	public CategoryService(CategoryRepository repository) 
		: base(repository)
	{
	}

	public CategoryDto? GetOrDefaultById(int id) =>
		_repository.GetOrDefaultById(id);
}
