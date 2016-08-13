using System.Collections.Generic;
using System.Configuration;
using Dapper;
using DataProvider.Contracts;

namespace DataProvider
{
    public class Session : ISession
    {
        private readonly IDapperContext _context;

        public Session(string connectionString)
        {
            _context = new DapperContext(ConfigurationManager.ConnectionStrings["TournamentDraws"].ConnectionString);
        }

        public Session(IDapperContext context)
        {
            _context = context;
        }

        public virtual IEnumerable<T> Query<T>(string query, object param)
        {
            return _context.Transaction(transaction =>
            {
                var result = _context.Connection.Query<T>(query, param, transaction);
                return result;
            });
        }

        public void Execute(string sql, object param)
        {
            _context.Transaction(transaction => _context.Connection.Execute(sql, param, transaction));
        }
    }
}