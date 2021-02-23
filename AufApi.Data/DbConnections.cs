using Microsoft.Extensions.Configuration;
using Npgsql;

namespace AufApi.Data
{
    public class DbConnections : IDbConnections
    {
        private readonly IConfiguration _configuration;

        public DbConnections(IConfiguration configuration) => _configuration = configuration;

        public NpgsqlConnection PgConnection() => new(_configuration.GetConnectionString("Postgres"));
    }
}