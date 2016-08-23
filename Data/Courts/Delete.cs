using DataProvider.Contracts;

namespace Data.Courts
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
            session.Execute("Delete from Courts where Id = @Id", new { Id = _id });
        }
    }
}
