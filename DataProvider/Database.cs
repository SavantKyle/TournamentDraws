namespace DataProvider
{
    public class Database : IDatabase
    {
        private ISession Session { get; }
        
        public Database(ISession session)
        {
            Session = session;
        }

        public T Query<T>(IQuery<T> query)
        {
            return query.Execute(Session);
        }

        public void Execute(ICommand command)
        {
            command.Execute(Session);
        }
    }
}