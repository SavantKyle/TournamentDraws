using System.Collections.Generic;
using Models;

namespace Business.Contracts
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAll();
        Player GetById(int id);
        Player Insert(Player player);
        void Update(int id);
        void Delete(int id);
    }
}