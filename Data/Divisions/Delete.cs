using DataProvider.Contracts;

namespace Data.Divisions
{
    public class Delete : ICommand
    {
        private readonly int _id;

        public Delete(int id)
        {
            _id = id;
        }

        public void Execute(ISession session)
        {
            session.Execute("Delete from Divisions where Id = @Id", new { Id = _id });
        }
    }
}
