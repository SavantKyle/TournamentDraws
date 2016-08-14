using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Tournaments
{
    public class GetAll : IQuery<IList<Tournament>>
    {
        public IList<Tournament> Execute(ISession session)
        {
            return session.Query<Tournament>("Select * from Tournaments").ToList();
        }
    }
}
