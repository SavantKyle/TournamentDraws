using DataProvider.Contracts;
using Models;

namespace Data.CourtTimes
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly CourtTime _courtTimes;

        public Update(int id, CourtTime courtTimes)
        {
            _id = id;
            _courtTimes = courtTimes;
        }

        public void Execute(ISession session)
        {
            session.Execute(
                @"Update CourtTimes 
                set StartTime = @StartTime, CourtId = @CourtId, IsAvailabe = @IsAvailable
                where Id = @Id",
                new { _courtTimes.StartTime, _courtTimes.CourtId, _courtTimes.IsAvailable, Id = _id });
        }
    }
}
