using System.Collections.Generic;

namespace DataProvider
{
    public interface ISession
    {
        IEnumerable<T> Query<T>(string query, object param = null);
        void Execute(string sql, object param);
    }
}