using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class MatchupsController : ApiController
    {
        private readonly IFacade _facade;

        public MatchupsController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Matchups
        public IEnumerable<Matchup> Get()
        {
            return _facade.MatchupService.GetAll();
        }

        // GET: api/Matchups/5
        public Matchup Get(int id)
        {
            return _facade.MatchupService.GetById(id);
        }

        // POST: api/Matchups
        public Matchup Post([FromBody]Matchup matchup)
        {
            return _facade.MatchupService.Insert(matchup);
        }

        // PUT: api/Matchups/5
        public void Put(int id, [FromBody]Matchup matchup)
        {
            _facade.MatchupService.Update(id, matchup);
        }

        // DELETE: api/Matchups/5
        public void Delete(int id)
        {
            _facade.MatchupService.Delete(id);
        }
    }
}
