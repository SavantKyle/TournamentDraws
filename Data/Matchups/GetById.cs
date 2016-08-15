using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Matchups
{
    public class GetById : IQuery<Matchup>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Matchup Execute(ISession session)
        {
            return session.Query<Matchup>("Select * from Matchups where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
