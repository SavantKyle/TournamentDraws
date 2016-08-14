using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.DivisionGroups
{
    public class Insert : IQuery<DivisionGroup>
    {
        private readonly DivisionGroup _divisionGroup;

        public Insert(DivisionGroup divisionGroup)
        {
            _divisionGroup = divisionGroup;
        }

        DivisionGroup IQuery<DivisionGroup>.Execute(ISession session)
        {
            _divisionGroup.Id = session.Query<int>(
                @"Insert into DivisionGroups (Description, Ntrp) values (@Description, @Ntrp); 
                select cast(scope_identity() as int)",
                new {_divisionGroup.Description, _divisionGroup.Ntrp}).First();
            return _divisionGroup;
        }
    }
}
