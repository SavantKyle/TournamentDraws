using System.Collections.Generic;
using Business.Contracts;
using Data.Facilities;
using DataProvider.Contracts;
using Models;

namespace Business
{
    public class FacilityService : IFacilityService
    {
        private readonly IDatabase _database;

        public FacilityService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<Facility> GetAll()
        {
            return _database.Query(new GetAll());
        }

        public Facility GetById(int id)
        {
            return _database.Query(new GetById(id));
        }

        public Facility Insert(Facility facility)
        {
            return _database.Query(new Insert(facility));
        }

        public void Update(int id, Facility facility)
        {
            _database.Execute(new Update(id, facility));
        }

        public void Delete(int id)
        {
            _database.Execute(new Delete(id));
        }
    }
}
