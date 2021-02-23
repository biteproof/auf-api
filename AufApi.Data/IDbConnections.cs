using Npgsql;

namespace AufApi.Data
{
    public interface IDbConnections
    {
        NpgsqlConnection PgConnection();
    }
}