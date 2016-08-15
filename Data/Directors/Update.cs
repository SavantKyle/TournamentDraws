using System;
using DataProvider.Contracts;
using Models;

namespace Data.Directors
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Director _director;

        public Update(int id, Director director)
        {
            _id = id;
            _director = director;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
