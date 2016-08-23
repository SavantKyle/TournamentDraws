using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class DivisionGroup : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Division> Divisions { get; set; } = new List<Division>();
        public ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}