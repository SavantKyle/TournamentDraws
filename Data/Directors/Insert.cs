using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Directors
{
    public class Insert : IQuery<Director>
    {
        private readonly Director _director;

        public Insert(Director director)
        {
            _director = director;
        }

        Director IQuery<Director>.Execute(ISession session)
        {
            _director.Id = session.Query<int>(
                @"Insert into Directors (FirstName, LastName, Phone, Email) values (@FirstName, @LastName, @Phone, @Email); 
                select cast(scope_identity() as int)",
                new { _director.FirstName, _director.LastName, _director.Phone, _director.Email }).First();
            return _director;
        }
    }
}
