using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataProvider.Contracts;

namespace Data.Players
{
    public class Update : ICommand
    {
        public Update()
        {
            
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
