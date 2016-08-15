using System.Collections.Generic;
using Business.Contracts;
using Data.DivisionGroups;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class DivisionGroupService : IDivisionGroupService
    {
        private readonly IDatabase _database;

        public DivisionGroupService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<DivisionGroup> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public DivisionGroup GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public DivisionGroup Insert(DivisionGroup divisionGroup)
        {
            return _database.Query(new Insert(divisionGroup));
        }

        public void Update(int id, DivisionGroup divisionGroup)
        {
            _database.Execute(new Update(id, divisionGroup));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
