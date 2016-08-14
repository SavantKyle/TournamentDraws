using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Directors
{
    public class GetAll : IQuery<IList<Director>>
    {
        public IList<Director> Execute(ISession session)
        {
            return session.Query<Director>("Select * from Directors").ToList();
        }
    }
}
