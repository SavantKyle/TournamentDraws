using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Courts
{
    public class GetById : IQuery<Court>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Court Execute(ISession session)
        {
            return session.Query<Court>("Select * from Courts where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
