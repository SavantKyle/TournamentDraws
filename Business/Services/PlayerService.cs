using System.Collections.Generic;
using Business.Contracts;
using Data.Players;
using DataProvider;
using Models;

namespace Business.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IDatabase _database;

        public PlayerService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Player> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Player GetById(int id)
        {
            return _database.Query(new GetById(id));
        }
    }
}
