using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class TeamsController : ApiController
    {
        private readonly IFacade _facade;

        public TeamsController(IFacade facade)
        {
            _facade = facade;
        }

        // GET: api/Teams
        public IEnumerable<Team> Get()
        {
            return _facade.TeamService.GetAll();
        }

        // GET: api/Teams/5
        public Team Get(int id)
        {
            return _facade.TeamService.GetById(id);
        }

        // POST: api/Teams
        public Team Post([FromBody]Team team)
        {
            return _facade.TeamService.Insert(team);
        }

        // PUT: api/Teams/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teams/5
        public void Delete(int id)
        {
            _facade.TeamService.Delete(id);
        }
    }
}
