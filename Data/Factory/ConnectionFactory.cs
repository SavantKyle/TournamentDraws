using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Data.Factory
{
    public class ConnectionFactory
    {
        public static IDbConnection GetOpenConnection()
        {
            IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TournamentDraws"].ConnectionString);
            connection.Open();

            return connection;
        }
    }

}
