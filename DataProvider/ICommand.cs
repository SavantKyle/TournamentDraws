namespace DataProvider
{
    public interface ICommand
    {
        void Execute(ISession session);
    }
}
