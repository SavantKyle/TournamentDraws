using System;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Addresses
{
    public class Insert : IQuery<Address>
    {
        private readonly Address _address;

        public Insert(Address address)
        {
            _address = address;
        }

        Address IQuery<Address>.Execute(ISession session)
        {
            _address.Id = session.Query<int>(
                @"Insert into Addresses (Street1, Street2, City, State, Zip) values (@Street1, @Street2, @City, @State, @Zip);
                select cast(scope_identity() as int)",
                new { _address.Street1, _address.Street2, _address.City, _address.State, _address.Zip }).First();
            return _address;
        }
    }
}
