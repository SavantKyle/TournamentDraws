using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Tournaments
{
    public class GetById : IQuery<Tournament>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Tournament Execute(ISession session)
        {
            return session.Query<Tournament>("Select * from Tournaments where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
