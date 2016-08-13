using System;
using System.Data;
using System.Data.SqlClient;
using DataProvider.Contracts;

namespace DataProvider
{
    public class DapperContext : IDapperContext
    {
        private readonly string _connectionString;
        private IDbConnection _connection;
        
        public DapperContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbTransaction DbTransaction { get; set; }

        /// <summary>
        ///     Get the current connection, or open a new connection
        /// </summary>
        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SqlConnection(_connectionString);

                if (string.IsNullOrWhiteSpace(_connection.ConnectionString))
                    _connection.ConnectionString = _connectionString;

                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();

                return _connection;
            }
        }

        /// <summary>
        ///     Start a new transaction if one is not already available
        /// </summary>
        public IDbTransaction BeginTransaction()
        {
            if (DbTransaction?.Connection == null)
                DbTransaction = Connection.BeginTransaction();

            return DbTransaction;
        }

        /// <summary>
        ///     Perform a transactionless query
        /// </summary>
        public T Transaction<T>(Func<IDbTransaction, T> query)
        {
            using (Connection)
            {
                using (var transaction = BeginTransaction())
                {
                    try
                    {
                        var result = query(transaction);
                        transaction.Commit();

                        return result;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        ///     Commit and dispose of the transaction
        /// </summary>
        public void Commit()
        {
            try
            {
                DbTransaction.Commit();
                DbTransaction.Dispose();
                DbTransaction = null;
            }
            catch (Exception ex)
            {
                if (DbTransaction?.Connection != null)
                    Rollback();

                throw new NullReferenceException("Tried Commit on closed Transaction", ex);
            }
        }

        /// <summary>
        ///     Rollback and dispose of the transaction
        /// </summary>
        public void Rollback()
        {
            try
            {
                DbTransaction.Rollback();
                DbTransaction.Dispose();
                DbTransaction = null;
            }
            catch (Exception ex)
            {
                throw new NullReferenceException("Tried Rollback on closed Transaction", ex);
            }
        }

        /// <summary>
        ///     Dispose of the transaction and close the connection
        /// </summary>
        public void Dispose()
        {
            if (DbTransaction != null)
            {
                DbTransaction.Dispose();
                DbTransaction = null;
            }

            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}