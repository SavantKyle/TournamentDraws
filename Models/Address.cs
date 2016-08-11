namespace Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PlayerId { get; set; }
        public int FacilityId { get; set; }
    }
}