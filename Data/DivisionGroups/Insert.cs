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
                @"Insert into DivisionGroups (Name) values (@Name); 
                select cast(scope_identity() as int)",
                new {_divisionGroup.Name }).First();
            return _divisionGroup;
        }
    }
}
