using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class TournamentsController : ApiController
    {
        private readonly IFacade _facade;

        public TournamentsController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Tournaments
        public IEnumerable<Tournament> Get()
        {
            return _facade.TournamentService.GetAll();
        }

        // GET: api/Tournaments/5
        public Tournament Get(int id)
        {
            return _facade.TournamentService.GetById(id);
        }

        // POST: api/Tournaments
        public Tournament Post([FromBody]Tournament tournament)
        {
            return _facade.TournamentService.Insert(tournament);
        }

        // PUT: api/Tournaments/5
        public void Put(int id, [FromBody]Tournament tournament)
        {
            _facade.TournamentService.Update(id, tournament);
        }

        // DELETE: api/Tournaments/5
        public void Delete(int id)
        {
            _facade.TournamentService.Delete(id);
        }
    }
}
