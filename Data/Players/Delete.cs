using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Contracts;

namespace Data.Players
{
    public class Delete : ICommand
    {
        private readonly int _id;

        public Delete(int id)
        {
            _id = id;
        }

        public void Execute(ISession session)
        {
            session.Execute("Delete from Players where Id = @Id", new { Id = _id });
        }
    }
}
