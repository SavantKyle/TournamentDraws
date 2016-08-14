using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Facilities
{
    public class GetAll : IQuery<IList<Facility>>
    {
        public IList<Facility> Execute(ISession session)
        {
            return session.Query<Facility>("Select * from Facilities").ToList();
        }
    }
}
