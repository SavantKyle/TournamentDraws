using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Addresses
{
    public class GetAll : IQuery<IList<Address>>
    {
        public IList<Address> Execute(ISession session)
        {
            return session.Query<Address>("Select * from Addresses").ToList();
        }
    }
}
