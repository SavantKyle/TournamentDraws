using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.DivisionGroups
{
    public class GetAll : IQuery<IList<DivisionGroup>>
    {
        public IList<DivisionGroup> Execute(ISession session)
        {
            return session.Query<DivisionGroup>("Select * from DivisionGroups").ToList();
        }
    }
}
