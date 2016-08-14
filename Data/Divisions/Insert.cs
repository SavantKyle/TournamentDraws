using System;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Divisions
{
    public class Insert : IQuery<Division>
    {
        private readonly Division _division;

        public Insert(Division division)
        {
            _division = division;
        }
        
        Division IQuery<Division>.Execute(ISession session)
        {
            _division.Id = session.Query<int>(
                @"Insert into Divisions (Description) values (@Description);
                select cast(scope_identity() as int)",
                new {_division.Description}).First();
            return _division;
        }
    }
}
