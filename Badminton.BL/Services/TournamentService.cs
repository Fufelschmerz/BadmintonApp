using Badminton.Contracts;
using BadmintonApp.Contracts;
using BadmintonApp.Data.Entities;
using BadmintonApp.Data.Repositories;

namespace Badminton.BL.Services;

public class TournamentService : BaseService<TournamentRepository, TournamentDto, Tournament>
{
	public TournamentService(TournamentRepository repository) 
		: base(repository)
	{
	}

	public override void InsertOrUpdate(TournamentDto dto)
	{
		var tournament = _repository.GetOrDefaultByTitle(dto.Title);

		if (tournament is not null && tournament.Id != dto.Id)
			throw new ArgumentException("Турнир с таким названием уже существует");

		base.InsertOrUpdate(dto);
    }

	public TournamentDto? GetOrDefaultByTitle(string title) =>
		_repository.GetOrDefaultByTitle(title);

	public void AddPlayersToTournament(string title, IEnumerable<PlayerDto> players)
	{
		var tournament = _repository.GetOrDefaultByTitle(title);

		if (tournament is null)
			throw new ArgumentNullException(nameof(tournament));

		tournament.Players = players;

		_repository.Update(tournament);
	}
}
