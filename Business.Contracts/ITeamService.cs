using System.Collections.Generic;
using Models;

namespace Business.Contracts
{
    public interface ITeamService
    {
        IEnumerable<Team> GetAll();
        Team GetById(int id);
        Team Insert(Team team);
        void Update(int id, Team team);
        void Delete(int id);
        IEnumerable<Team> GetWithRating(int tournamentId);
    }
}
