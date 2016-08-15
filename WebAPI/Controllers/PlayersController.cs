using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class PlayersController : ApiController
    {
        private readonly IFacade _facade;

        public PlayersController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Players
        public IEnumerable<Player> Get()
        {
            return _facade.PlayerService.GetAll();
        }

        // GET: api/Players/5
        public Player Get(int id)
        {
            return _facade.PlayerService.GetById(id);
        }

        // POST: api/Players
        public Player Post([FromBody]Player player)
        {
            return _facade.PlayerService.Insert(player);
        }

        // PUT: api/Players/5
        public void Put(int id, [FromBody]Player player)
        {
            _facade.PlayerService.Update(id, player);
        }

        // DELETE: api/Players/5
        public void Delete(int id)
        {
            _facade.PlayerService.Delete(id);
        }
    }
}
