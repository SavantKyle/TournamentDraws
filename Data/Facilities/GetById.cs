using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Facilities
{
    public class GetById : IQuery<Facility>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Facility Execute(ISession session)
        {
            return session.Query<Facility>("Select * from Facilities where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
