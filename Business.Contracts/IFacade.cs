namespace Business.Contracts
{
    public interface IFacade
    {
        IPlayerService PlayerService { get; }
        ITeamService TeamService { get; }
    }
}
