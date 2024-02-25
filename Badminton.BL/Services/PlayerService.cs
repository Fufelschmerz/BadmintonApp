using Badminton.Contracts;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class PlayerService
{
	private readonly PlayerRepository _playerRepository = new();

	public void InsertOrUpdate(PlayerDto player)
	{
		if (player.Id is not null)
		{
			_playerRepository.Update(player);
			return;
		}

		_playerRepository.Insert(player);
	}

	public void DeleteRange(IEnumerable<int> ids) =>
		_playerRepository.DeleteRange(ids);

	public IEnumerable<PlayerDto> GetAll() =>
		_playerRepository.GetAll();
}
