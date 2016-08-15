using System;
using DataProvider.Contracts;
using Models;

namespace Data.Facilities
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Facility _facility;

        public Update(int id, Facility facility)
        {
            _id = id;
            _facility = facility;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
