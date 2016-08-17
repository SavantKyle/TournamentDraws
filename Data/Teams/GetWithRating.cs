using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Contracts;
using Models;

namespace Data.Teams
{
    public class GetWithRating : IQuery<List<Team>>
    {
        private readonly int _tournamentId;

        public GetWithRating(int tournamentId)
        {
            _tournamentId = tournamentId;
        }

        public List<Team> Execute(ISession session)
        {
            return session.Query<Team>(@"Select * from Teams t join Ratings r on t.RatingId = r.Id where t.TournamentId = @TournamentId", new { TournamentId = _tournamentId }).ToList();
        }
    }
}
