using System.Collections.Generic;

namespace Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<Director> Directors { get; set; } = new List<Director>();
        public ICollection<Facility> Facilities { get; set; } = new List<Facility>();
    }
}