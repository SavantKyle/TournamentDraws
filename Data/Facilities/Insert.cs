using System;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Facilities
{
    public class Insert : IQuery<Facility>
    {
        private readonly Facility _facility;

        public Insert(Facility facility)
        {
            _facility = facility;
        }
        
        Facility IQuery<Facility>.Execute(ISession session)
        {
            _facility.Id = session.Query<int>(
                @"Insert into Facilities (Name, Phone) values (@Name, @Phone); 
                select cast(scope_identity() as int)",
                new {_facility.Name, _facility.Phone}).First();
            return _facility;
        }
    }
}
