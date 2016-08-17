using Models.Contracts;

namespace Models
{
    public class Facility : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int AddressId { get; set; }
        public int TournamentId { get; set; }

        public Address Address { get; set; }
        public Tournament Tournament { get; set; }
    }
}
