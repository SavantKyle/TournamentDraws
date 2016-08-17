using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contracts;
using Models.Enums;

namespace Models
{
    public class Rating : IEntity
    {
        public int Id { get; set; }
        public decimal NtrpRating { get; set; }
        public RatingTypeEnum RatingTypeEnum { get; set; }

        public ICollection<Team> Teams { get; set; } = new List<Team>();
        public ICollection<DivisionGroup> DivisionGroups { get; set; } = new List<DivisionGroup>();
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
