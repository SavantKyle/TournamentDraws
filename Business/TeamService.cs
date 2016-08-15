using System.Collections.Generic;
using Business.Contracts;
using Data.Teams;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class TeamService : ITeamService
    {
        private readonly IDatabase _database;

        public TeamService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Team> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Team GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Team Insert(Team team)
        {
            return _database.Query(new Insert(team));
        }

        public void Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
