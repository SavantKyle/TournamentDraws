using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.CourtTimes
{
    public class Insert : IQuery<CourtTime>
    {
        private readonly CourtTime _courtTimes;

        public Insert(CourtTime courtTimes)
        {
            _courtTimes = courtTimes;
        }

        CourtTime IQuery<CourtTime>.Execute(ISession session)
        {
            _courtTimes.Id = session.Query<int>(
                    @"Insert into CourtTimes (StartTime, CourtId, IsAvailable) values (@StartTime, @CourtId, @IsAvailable);
                    select cast(scope_identity() as int)",
                    new { _courtTimes.StartTime, _courtTimes.CourtId, _courtTimes.IsAvailable }).First();
            return _courtTimes;
        }
    }
}
