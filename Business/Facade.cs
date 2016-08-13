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

        private ITeamService _teamService;
        public ITeamService TeamService => _teamService ?? (_teamService = new TeamService(_database));
    }
}