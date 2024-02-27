using BadmintonApp.Contracts;
using Badminton.Contracts;
using BadmintonApp.Data.Repositories;
using BadmintonApp.Data.Entities.Players;

namespace Badminton.BL.Services
{
    public class RankService
    {
        private readonly RankRepository _rankRepository = new();

        public IEnumerable<RankDto> GetAll() =>
            _rankRepository.GetAll();
    }
}
