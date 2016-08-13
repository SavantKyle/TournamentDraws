using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Ntrp { get; set; }
        public int TeamId { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}