using DataProvider.Contracts;

namespace Data.Players
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
            session.Execute("Delete from Players where Id = @Id", new { Id = _id });
        }
    }
}
