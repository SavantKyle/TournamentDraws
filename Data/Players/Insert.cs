using System.Linq;
using DataProvider.Contracts;
using Models;

namespace Data.Players
{
    public class Insert : IQuery<Player>
    {
        private readonly Player _player;

        public Insert(Player player)
        {
            _player = player;
        }
        
        Player IQuery<Player>.Execute(ISession session)
        {
            _player.Id = session.Query<int>(
                    @"Insert into Players (FirstName, LastName, Email, Phone, Ntrp) values (@FirstName, @LastName, @Email, @Phone, @Ntrp);
                    select cast(scope_identity() as int)",
                    new {_player.FirstName, _player.LastName, _player.Email, _player.Phone, _player.Ntrp}).First();
            return _player;
        }
    }
}
