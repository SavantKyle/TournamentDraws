﻿namespace Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int AddressId { get; set; }
        public int TournamentId { get; set; }
    }
}
