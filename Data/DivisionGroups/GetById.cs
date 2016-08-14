using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.DivisionGroups
{
    public class GetById : IQuery<DivisionGroup>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public DivisionGroup Execute(ISession session)
        {
            return session.Query<DivisionGroup>("Select * from DivisionGroups where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
