using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class DirectorsController : ApiController
    {
        private readonly IFacade _facade;

        public DirectorsController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Directors
        public IEnumerable<Director> Get()
        {
            return _facade.DirectorService.GetAll();
        }

        // GET: api/Directors/5
        public Director Get(int id)
        {
            return _facade.DirectorService.GetById(id);
        }

        // POST: api/Directors
        public Director Post([FromBody]Director director)
        {
            return _facade.DirectorService.Insert(director);
        }

        // PUT: api/Directors/5
        public void Put(int id, [FromBody]Director director)
        {
            _facade.DirectorService.Update(id, director);
        }

        // DELETE: api/Directors/5
        public void Delete(int id)
        {
            _facade.DirectorService.Delete(id);
        }
    }
}
