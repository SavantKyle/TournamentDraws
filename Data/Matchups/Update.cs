using System;
using DataProvider.Contracts;
using Models;

namespace Data.Matchups
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Matchup _matchup;

        public Update(int id, Matchup matchup)
        {
            _id = id;
            _matchup = matchup;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
