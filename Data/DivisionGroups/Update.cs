using System;
using DataProvider.Contracts;
using Models;

namespace Data.DivisionGroups
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly DivisionGroup _divisionGroup;

        public Update(int id, DivisionGroup divisionGroup)
        {
            _id = id;
            _divisionGroup = divisionGroup;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
