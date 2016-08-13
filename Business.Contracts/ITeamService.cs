using System.Collections.Generic;
using Models;

namespace Business.Contracts
{
    public interface ITeamService
    {
        IEnumerable<Team> GetAll();
        Team GetById(int id);
    }
}
