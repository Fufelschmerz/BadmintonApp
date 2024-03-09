using BadmintonApp.Contracts;
using Badminton.Contracts;
using BadmintonApp.Data.Repositories;
using BadmintonApp.Data.Entities.Players;

namespace Badminton.BL.Services
{
    public class RankService : BaseService<RankRepository, RankDto, Rank>
    {
		public RankService(RankRepository repository) 
			: base(repository)
		{
		}

		public RankDto? GetOrDefaultByName(string name) =>
            _repository.GetOrDefaultByName(name);
    }
}
