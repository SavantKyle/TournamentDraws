using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class DivisionsController : ApiController
    {
        private readonly IFacade _facade;

        public DivisionsController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Divisions
        public IEnumerable<Division> Get()
        {
            return _facade.DivisionService.GetAll();
        }

        // GET: api/Divisions/5
        public Division Get(int id)
        {
            return _facade.DivisionService.GetById(id);
        }

        // POST: api/Divisions
        public Division Post([FromBody]Division division)
        {
            return _facade.DivisionService.Insert(division);
        }

        // PUT: api/Divisions/5
        public void Put(int id, [FromBody]Division division)
        {
            _facade.DivisionService.Update(id, division);
        }

        // DELETE: api/Divisions/5
        public void Delete(int id)
        {
            _facade.DivisionService.Delete(id);
        }
    }
}
