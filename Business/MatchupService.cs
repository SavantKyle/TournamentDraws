using System.Collections.Generic;
using Business.Contracts;
using Data.Matchups;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class MatchupService : IMatchupService
    {
        private readonly IDatabase _database;

        public MatchupService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Matchup> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Matchup GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Matchup Insert(Matchup matchup)
        {
            return _database.Query(new Insert(matchup));
        }

        public void Update(int id, Matchup matchup)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
