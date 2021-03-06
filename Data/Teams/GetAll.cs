﻿using System.Collections.Generic;
using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Teams
{
    public class GetAll : IQuery<IList<Team>>
    {
        public IList<Team> Execute(ISession session)
        {
            return session.Query<Team>("Select * from Teams").ToList();
        }
    }
}
