using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetAll();
        Director GetById(int id);
        Director Insert(Director director);
        void Update(int id, Director director);
        void Delete(int id);
    }
}
