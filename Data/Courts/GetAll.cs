using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Courts
{
    public class GetAll : IQuery<IList<Court>>
    {
        public IList<Court> Execute(ISession session)
        {
            return session.Query<Court>("Select * from Courts").ToList();
        }
    }
}
