using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class DivisionGroup : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int RatingId { get; set; }

        public Rating Rating { get; set; }
        public ICollection<Division> Divisions { get; set; } = new List<Division>();
    }
}