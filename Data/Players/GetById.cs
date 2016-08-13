using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider;
using Models;

namespace Data.Players
{
    public class GetById : IQuery<Player>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Player Execute(ISession session)
        {
            return session.Query<Player>("Select * from Players where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
