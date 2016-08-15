using System;
using DataProvider.Contracts;
using Models;

namespace Data.Addresses
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Address _address;

        public Update(int id, Address address)
        {
            _id = id;
            _address = address;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
