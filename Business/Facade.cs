using Business.Contracts;
using DataProvider.Contracts;

namespace Business
{
    public class Facade : IFacade
    {
        private readonly IDatabase _database;

        public Facade(IDatabase database)
        {
            _database = database;
        }

        private IPlayerService _playerService;
        public IPlayerService PlayerService => _playerService ?? (_playerService = new PlayerService(_database));
    }
}