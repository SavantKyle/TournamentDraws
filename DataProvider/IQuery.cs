namespace DataProvider
{
    public interface IQuery<out T>
    {
        T Execute(ISession session);
    }
}
