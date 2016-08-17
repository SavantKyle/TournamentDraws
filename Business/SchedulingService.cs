using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Contracts;
using Models;

namespace Business
{
    public class SchedulingService : ISchedulingService
    {
        private readonly IFacade _facade;

        public SchedulingService(IFacade facade)
        {
            _facade = facade;
        }

        public List<Matchup> GenerateSchedule(Tournament tournament)
        {
            var teams = _facade.TeamService.GetWithRating(tournament.Id);
            var teamsAt4 = new List<Team>();

            foreach (var team in teams)
            {
                switch (team.Rating.NtrpRating.ToString())
                {
                    case "2.5":
                    case "3.0":
                    case "3.5":
                        break;
                    case "4.0":
                        teamsAt4.Add(team);
                        break;
                    case "4.5":
                    case "5.0":
                    default: break;
                }
            }

            return new List<Matchup>();
        }
    }
}
