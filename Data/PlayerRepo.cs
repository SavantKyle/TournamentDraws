using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Data
{
    public class PlayerRepo
    {
        public List<Player> Get()
        {
            using (var connection = Factory.ConnectionFactory.GetOpenConnection())
            {
                return connection.Query<Player>("Select * from Players").ToList();
            }   
        }
    }
}
