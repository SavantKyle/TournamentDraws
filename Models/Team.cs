using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RatingId { get; set; }
        public int DivisionId { get; set; }
        public int TournamentId { get; set; }

        public Rating Rating { get; set; }
        public Division Division { get; set; }
        public Tournament Tournament { get; set; }
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
