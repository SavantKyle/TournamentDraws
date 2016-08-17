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
        public int RatingId { get; set; }
        public int TeamId { get; set; }

        public Rating Rating { get; set; }
        public Team Team { get; set; }
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}