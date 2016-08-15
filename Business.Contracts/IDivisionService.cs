using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface IDivisionService
    {
        IEnumerable<Division> GetAll();
        Division GetById(int id);
        Division Insert(Division division);
        void Update(int id, Division division);
        void Delete(int id);
    }
}
