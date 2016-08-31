using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.CourtTimes
{
    public class GetAll : IQuery<IList<CourtTime>>
    {
        public IList<CourtTime> Execute(ISession session)
        {
            return session.Query<CourtTime>("Select * from CourtTimes").ToList();
        }
    }
}
