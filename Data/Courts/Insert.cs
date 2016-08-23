using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Courts
{
    public class Insert : IQuery<Court>
    {
        private readonly Court _court;

        public Insert(Court court)
        {
            _court = court;
        }

        Court IQuery<Court>.Execute(ISession session)
        {
            _court.Id = session.Query<int>(
                    @"Insert into Courts (Name) values (@Name);
                    select cast(scope_identity() as int)",
                    new { _court.Name }).First();
            return _court;
        }
    }
}
