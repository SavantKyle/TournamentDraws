using System.Collections.Generic;
using System.Web.Http;
using Business.Contracts;
using Models;

namespace WebAPI.Controllers
{
    public class AddressesController : ApiController
    {
        private readonly IFacade _facade;

        public AddressesController(IFacade facade)
        {
            _facade = facade;
        }
        
        // GET: api/Addresss
        public IEnumerable<Address> Get()
        {
            return _facade.AddressService.GetAll();
        }

        // GET: api/Addresss/5
        public Address Get(int id)
        {
            return _facade.AddressService.GetById(id);
        }

        // POST: api/Addresss
        public Address Post([FromBody]Address address)
        {
            return _facade.AddressService.Insert(address);
        }

        // PUT: api/Addresss/5
        public void Put(int id, [FromBody]Address address)
        {
            _facade.AddressService.Update(id, address);
        }

        // DELETE: api/Addresss/5
        public void Delete(int id)
        {
            _facade.AddressService.Delete(id);
        }
    }
}
