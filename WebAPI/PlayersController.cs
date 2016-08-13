using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Business.Contracts;
using Business.Services;
using DataProvider;
using Models;

namespace WebAPI
{
    public class PlayersController : ApiController
    {
        private readonly IDatabase _database;

        public PlayersController(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Player> GetAll()
        {
            return new PlayerService().GetAll();
        }
    }
}
