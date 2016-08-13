using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class Tournament : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ICollection<Director> Directors { get; set; } = new List<Director>();
        public ICollection<Facility> Facilities { get; set; } = new List<Facility>();
    }
}