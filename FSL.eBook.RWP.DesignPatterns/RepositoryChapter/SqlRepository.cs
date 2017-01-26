using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FSL.eBook.RWP.DesignPatterns.RepositoryChapter
{
    public abstract class SqlRepository : IDisposable
    {
        public SqlRepository() : this("RealWorldProgramming")
        {

        }

        public SqlRepository(string connectionStringId)
        {
            _connectionStringId = connectionStringId;
        }
        
        public virtual string ConnnectionStringId
        {
            get
            {
                return _connectionStringId;
            }
        }
        
        protected SqlConnection Database
        {
            get
            {
                if (_connection == null)
                {
                    if (string.IsNullOrEmpty(_connectionString))
                    {
                        _connectionString = ConfigurationManager.ConnectionStrings[ConnnectionStringId].ConnectionString;
                    }

                    _connection = new SqlConnection(_connectionString);
                }

                return _connection;
            }
        }

        public SqlRepository UseConnectionStringId(string connectionStringId)
        {
            _connectionStringId = connectionStringId;

            return this;
        }

        public SqlRepository UseConnectionString(string connectionString)
        {
            _connectionString = connectionString;

            return this;
        }

        public virtual void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
            }
        }
        
        private SqlConnection _connection = null;
        private string _connectionStringId;
        private string _connectionString;
    }
}