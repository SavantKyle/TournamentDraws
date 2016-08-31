using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.CourtTimes
{
    public class GetById : IQuery<CourtTime>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public CourtTime Execute(ISession session)
        {
            return session.Query<CourtTime>("Select * from CourtTimes where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
