using System.Collections.Generic;
using Business.Contracts;
using Data.Addresses;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class AddressService : IAddressService
    {
        private readonly IDatabase _database;

        public AddressService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Address> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Address GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Address Insert(Address address)
        {
            return _database.Query(new Insert(address));
        }

        public void Update(int id, Address address)
        {
            _database.Execute(new Update(id, address));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
