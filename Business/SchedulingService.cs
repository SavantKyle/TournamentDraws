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

        private class DaysOfPlay
        {
            private List<string> _times;
            public string Date { get; set; }
            public string FirstMatchStart { get; set; }
            public string LastMatchStart { get; set; }

            public List<string> Times
            {
                get { return _times; }
                set
                {
                    _times = value;
                    _times.Add(FirstMatchStart);

                    while (_times.Last() != LastMatchStart)
                    {
                        // Matches are scheduled 90 minutes apart 
                        _times.Add(DateTime.Parse(_times.Last()).AddMinutes(90).ToShortTimeString());
                    }

                    _times.Add(LastMatchStart);
                }
            }
        }

        public List<Matchup> GenerateSchedule(Tournament tournament)
        {
            var daysOfPlay = new List<DaysOfPlay>
            {
               new DaysOfPlay { Date = DateTime.Parse("9/2/2016").ToShortDateString(), FirstMatchStart = DateTime.Parse("5:30pm").ToShortTimeString(), LastMatchStart = DateTime.Parse("8:30pm").ToShortTimeString() },
               new DaysOfPlay { Date = DateTime.Parse("9/3/2016").ToShortDateString(), FirstMatchStart = DateTime.Parse("8am").ToShortTimeString(), LastMatchStart = DateTime.Parse("3:30pm").ToShortTimeString() },
               new DaysOfPlay { Date = DateTime.Parse("9/4/2016").ToShortDateString(), FirstMatchStart = DateTime.Parse("8am").ToShortTimeString(), LastMatchStart = DateTime.Parse("3:30pm").ToShortTimeString() }
            };
            //var matchLengthMinutes = 90;
            
            var teams = _facade.TeamService.GetWithRating(tournament.Id);
            var teamsAt4 = new List<Team>();

            foreach (var team in teams)
            {
                switch (team.Rating.NtrpRating.ToString("##.#"))
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
