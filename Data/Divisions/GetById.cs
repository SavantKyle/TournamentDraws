using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Divisions
{
    public class GetById : IQuery<Division>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Division Execute(ISession session)
        {
            return session.Query<Division>("Select * from Divisions where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
