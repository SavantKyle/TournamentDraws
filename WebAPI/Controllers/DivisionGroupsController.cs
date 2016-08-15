using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class DivisionGroupsController : ApiController
    {
        private readonly IFacade _facade;

        public DivisionGroupsController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/DivisionGroups
        public IEnumerable<DivisionGroup> Get()
        {
            return _facade.DivisionGroupService.GetAll();
        }

        // GET: api/DivisionGroups/5
        public DivisionGroup Get(int id)
        {
            return _facade.DivisionGroupService.GetById(id);
        }

        // POST: api/DivisionGroups
        public DivisionGroup Post([FromBody]DivisionGroup divisionGroup)
        {
            return _facade.DivisionGroupService.Insert(divisionGroup);
        }

        // PUT: api/DivisionGroups/5
        public void Put(int id, [FromBody]DivisionGroup divisionGroup)
        {
            _facade.DivisionGroupService.Update(id, divisionGroup);
        }

        // DELETE: api/DivisionGroups/5
        public void Delete(int id)
        {
            _facade.DivisionGroupService.Delete(id);
        }
    }
}
