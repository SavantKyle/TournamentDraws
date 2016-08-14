using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Addresses
{
    public class GetById : IQuery<Address>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Address Execute(ISession session)
        {
            return session.Query<Address>("Select * from Addresses where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
