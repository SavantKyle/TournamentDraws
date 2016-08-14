using DataProvider.Contracts;

namespace Data.Tournaments
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
            session.Execute("Delete from Tournaments where Id = @Id", new { Id = _id });
        }
    }
}
