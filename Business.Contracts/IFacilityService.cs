using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Business.Contracts
{
    public interface IFacilityService
    {
        IEnumerable<Facility> GetAll();
        Facility GetById(int id);
        Facility Insert(Facility facility);
        void Update(int id, Facility facility);
        void Delete(int id);
    }
}
