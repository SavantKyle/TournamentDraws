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

        private IAddressService _addressService;
        public IAddressService AddressService => _addressService ?? (_addressService = new AddressService(_database));

        private IDirectorService _directorService;
        public IDirectorService DirectorService => _directorService ?? (_directorService = new DirectorService(_database));

        private IDivisionGroupService _divisionGroupService;
        public IDivisionGroupService DivisionGroupService => _divisionGroupService ?? (_divisionGroupService = new DivisionGroupService(_database));

        private IDivisionService _divisionService;
        public IDivisionService DivisionService => _divisionService ?? (_divisionService = new DivisionService(_database));

        private IFacilityService _facilityService;
        public IFacilityService FacilityService => _facilityService ?? (_facilityService = new FacilityService(_database));

        private IMatchupService _matchupService;
        public IMatchupService MatchupService => _matchupService ?? (_matchupService = new MatchupService(_database));

        private IPlayerService _playerService;
        public IPlayerService PlayerService => _playerService ?? (_playerService = new PlayerService(_database));

        private ITeamService _teamService;
        public ITeamService TeamService => _teamService ?? (_teamService = new TeamService(_database));

        private ITournamentService _tournamentService;
        public ITournamentService TournamentService => _tournamentService ?? (_tournamentService = new TournamentService(_database));
    }
}