using System.Collections.Generic;
using Business.Contracts;
using Data.Divisions;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class DivisionService : IDivisionService
    {
        private readonly IDatabase _database;

        public DivisionService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Division> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Division GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Division Insert(Division division)
        {
            return _database.Query(new Insert(division));
        }

        public void Update(int id, Division division)
        {
            _database.Execute(new Update(id, division));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
