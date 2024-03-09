using Badminton.Contracts;
using BadmintonApp.Contracts.Models;
using BadmintonApp.Data.Entities.Players;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class PlayerService : BaseService<PlayerRepository, PlayerDto, Player>
{	
	public PlayerService(PlayerRepository repository) 
		: base(repository)
	{
	}

	public void DeleteRange(IEnumerable<int> ids) =>
		_repository.DeleteRange(ids);

	public IEnumerable<PlayerDto> GetAll() =>
		_repository.GetAll();

	public IEnumerable<PlayerDto> GetAllByFilters(GetPlayersModel parameters) =>
		_repository.GetAllByFilters(parameters);

	public PlayerDto? GetOrDefaultByIdAsync(int id) =>
		_repository.GetOrDefaultById(id);
}
