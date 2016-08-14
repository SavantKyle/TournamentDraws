using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Teams
{
    public class Insert : IQuery<Team>
    {
        private readonly Team _team;

        public Insert(Team team)
        {
            _team = team;
        }
        
        Team IQuery<Team>.Execute(ISession session)
        {
            _team.Id = session.Query<int>(
                @"Insert into Teams (Name) values (@Name); 
                select cast(scope_identity() as int)",
                new {_team.Name}).First();
            return _team;
        }
    }
}
