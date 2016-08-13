namespace DataProvider.Contracts
{
    public interface IQuery<out T>
    {
        T Execute(ISession session);
    }
}
