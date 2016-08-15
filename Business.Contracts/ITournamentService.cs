using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface ITournamentService
    {
        IEnumerable<Tournament> GetAll();
        Tournament GetById(int id);
        Tournament Insert(Tournament tournament);
        void Update(int id, Tournament tournament);
        void Delete(int id);
    }
}
