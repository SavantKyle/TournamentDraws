using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Directors
{
    public class GetById : IQuery<Director>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Director Execute(ISession session)
        {
            return session.Query<Director>("Select * from Directors where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
