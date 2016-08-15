using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface IMatchupService
    {
        IEnumerable<Matchup> GetAll();
        Matchup GetById(int id);
        Matchup Insert(Matchup matchup);
        void Update(int id, Matchup matchup);
        void Delete(int id);
    }
}
