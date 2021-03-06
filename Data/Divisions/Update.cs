﻿using System;
using DataProvider.Contracts;
using Models;

namespace Data.Divisions
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Division _division;

        public Update(int id, Division division)
        {
            _id = id;
            _division = division;
        }

        public void Execute(ISession session)
        {
            throw new NotImplementedException();
        }
    }
}
