﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Contracts;

namespace Models
{
    public class Matchup : IEntity
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int Team1Id { get; set; }
        public int Team2Id { get; set; }
        public int FacilityId { get; set; }
    }
}