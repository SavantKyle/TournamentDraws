using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface IDivisionGroupService
    {
        IEnumerable<DivisionGroup> GetAll();
        DivisionGroup GetById(int id);
        DivisionGroup Insert(DivisionGroup divisionGroup);
        void Update(int id, DivisionGroup divisionGroup);
        void Delete(int id);
    }
}
