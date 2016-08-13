using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Players
{
    public class GetById : IQuery<Player>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Player Execute(ISession session)
        {
            return session.Query<Player>("Select * from Players where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
