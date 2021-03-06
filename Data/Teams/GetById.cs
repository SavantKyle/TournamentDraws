﻿using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Teams
{
    public class GetById : IQuery<Team>
    {
        private readonly int _id;

        public GetById(int id)
        {
            _id = id;
        }

        public Team Execute(ISession session)
        {
            return session.Query<Team>("Select * from Teams where Id = @Id", new { Id = _id }).SingleOrDefault();
        }
    }
}
