using System;
using DataProvider.Contracts;
using Models;

namespace Data.Players
{
    public class Update : ICommand
    {
        private readonly int _id;
        private readonly Player _player;

        public Update(int id, Player player)
        {
            _id = id;
            _player = player;
        }

        public void Execute(ISession session)
        {
            session.Execute(
                @"Update Players 
                set FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, RatingId = @RatingId
                where Id = @Id",
                new { _player.FirstName, _player.LastName, _player.Phone, _player.Email, _player.RatingId, Id = _id });
        }
    }
}
