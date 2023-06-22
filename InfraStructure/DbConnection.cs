using System.Data.SqlClient;

namespace API_Authentication.DBConnection
{
    public class DbConnection : IDisposable
    {
        private readonly IConfiguration _configuration;
        public SqlConnection Connection { get; set; }

        public DbConnection(IConfiguration configuration) 
        { 
            _configuration = configuration;
            Connection = new SqlConnection(_configuration.GetConnectionString("STRING_CONNECTION"));
            Connection.Open();
        }

        public void Dispose()
        {
           Connection.Dispose();
        }
    }
}
