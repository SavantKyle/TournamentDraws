using System.Collections.Generic;
using System.Linq;
using DataProvider;
using Models;

namespace Data.Players
{
    public class GetAll : IQuery<IList<Player>>
    {
        public IList<Player> Execute(ISession session)
        {
            return session.Query<Player>("Select * from Players").ToList();
        }
    }
}
