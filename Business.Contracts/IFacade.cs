namespace Business.Contracts
{
    public interface IFacade
    {
        IAddressService AddressService { get; }
        IDirectorService DirectorService { get; }
        IDivisionGroupService DivisionGroupService { get; }
        IDivisionService DivisionService { get; }
        IFacilityService FacilityService { get; }
        IMatchupService MatchupService { get; }
        IPlayerService PlayerService { get; }
        ITeamService TeamService { get; }
        ITournamentService TournamentService { get; }
        ISchedulingService SchedulingService { get; }
    }
}
