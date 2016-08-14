using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Divisions
{
    public class GetAll : IQuery<IList<Division>>
    {
        public IList<Division> Execute(ISession session)
        {
            return session.Query<Division>("Select * from Divisions").ToList();
        }
    }
}
