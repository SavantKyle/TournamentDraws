using System;
using System.Collections.Generic;
using Models.Contracts;

namespace Models
{
    public class MatchDateTime : IEntity
    {
        public int Id { get; set; }
        public DateTime DateTimeOfPlay { get; set; }
        public bool IsAvailable { get; set; }
        public int CourtId { get; set; }

        public Court Court { get; set; }
        public ICollection<Matchup> Matchups { get; set; } = new List<Matchup>();
    }
}