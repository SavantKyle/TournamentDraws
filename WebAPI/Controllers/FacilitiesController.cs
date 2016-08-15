using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class FacilitiesController : ApiController
    {
        private readonly IFacade _facade;

        public FacilitiesController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Facilitys
        public IEnumerable<Facility> Get()
        {
            return _facade.FacilityService.GetAll();
        }

        // GET: api/Facilitys/5
        public Facility Get(int id)
        {
            return _facade.FacilityService.GetById(id);
        }

        // POST: api/Facilitys
        public Facility Post([FromBody]Facility facility)
        {
            return _facade.FacilityService.Insert(facility);
        }

        // PUT: api/Facilitys/5
        public void Put(int id, [FromBody]Facility facility)
        {
            _facade.FacilityService.Update(id, facility);
        }

        // DELETE: api/Facilitys/5
        public void Delete(int id)
        {
            _facade.FacilityService.Delete(id);
        }
    }
}
