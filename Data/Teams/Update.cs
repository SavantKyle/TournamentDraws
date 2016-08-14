using System;
using DataProvider.Contracts;

namespace Data.Teams
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
