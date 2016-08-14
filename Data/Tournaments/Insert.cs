using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Tournaments
{
    public class Insert : IQuery<Tournament>
    {
        private readonly Tournament _tournament;

        public Insert(Tournament tournament)
        {
            _tournament = tournament;
        }
        
        Tournament IQuery<Tournament>.Execute(ISession session)
        {
            _tournament.Id = session.Query<int>(
                @"Insert into Tournaments () values (); 
                select cast(scope_identity() as int)",
                new {_tournament.Name, _tournament.Url}).First();
            return _tournament;
        }
    }
}
