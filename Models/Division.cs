using System.Collections.Generic;

namespace Models
{
    public class Division
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int DivisionGroupId { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}