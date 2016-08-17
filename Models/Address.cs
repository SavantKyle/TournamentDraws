using Models.Contracts;

namespace Models
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PlayerId { get; set; }
        public int FacilityId { get; set; }

        public Player Player { get; set; }
        public Facility Facility { get; set; }
    }
}