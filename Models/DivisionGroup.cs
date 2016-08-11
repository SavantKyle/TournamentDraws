using System.Collections.Generic;

namespace Models
{
    public class DivisionGroup
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Ntrp { get; set; }
        public ICollection<Division> Divisions { get; set; } = new List<Division>();
    }
}