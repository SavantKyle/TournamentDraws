using System.Collections.Generic;
using Business.Contracts;
using Data.Tournaments;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class TournamentService : ITournamentService
    {
        private readonly IDatabase _database;

        public TournamentService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Tournament> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Tournament GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Tournament Insert(Tournament tournament)
        {
            return _database.Query(new Insert(tournament));
        }

        public void Update(int id, Tournament tournament)
        {
            _database.Execute(new Update(id, tournament));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
