namespace DataProvider.Contracts
{
    public interface ICommand
    {
        void Execute(ISession session);
    }
}
