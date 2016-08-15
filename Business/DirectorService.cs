using System.Collections.Generic;
using Business.Contracts;
using Data.Directors;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class DirectorService : IDirectorService
    {
        private readonly IDatabase _database;

        public DirectorService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Director> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Director GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Director Insert(Director director)
        {
            return _database.Query(new Insert(director));
        }

        public void Update(int id, Director director)
        {
            _database.Execute(new Update(id, director));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
