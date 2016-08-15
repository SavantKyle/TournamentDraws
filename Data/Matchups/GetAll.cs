using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Matchups
{
    public class GetAll : IQuery<IList<Matchup>>
    {
        public IList<Matchup> Execute(ISession session)
        {
            return session.Query<Matchup>("Select * from Matchups").ToList();
        }
    }
}
