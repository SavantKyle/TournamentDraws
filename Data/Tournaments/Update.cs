using System;
using DataProvider.Contracts;
using Models;

namespace Data.Tournaments
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Tournament _tournament;

        public Update(int id, Tournament tournament)
        {
            _id = id;
            _tournament = tournament;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
