using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Matchups
{
    public class Insert : IQuery<Matchup>
    {
        private readonly Matchup _matchup;

        public Insert(Matchup matchup)
        {
            _matchup = matchup;
        }

        Matchup IQuery<Matchup>.Execute(ISession session)
        {
            _matchup.Id = session.Query<int>(
                @"Insert into Matchups (Start, Team1Id, Team2Id, FacilityId) values (@Start, @Team1Id, @Team2Id, @FacilityId); 
                select cast(scope_identity() as int)",
                new { _matchup.Start, _matchup.Team1Id, _matchup.Team2Id, _matchup.FacilityId }).First();
            return _matchup;
        }
    }
}
