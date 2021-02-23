using System.Collections.Generic;
using System.Threading.Tasks;
using AufApi.Data.Models;
using AufApi.Data.Queries;
using Dapper;

namespace AufApi.Data
{
    public class GitlabRepository : IGitlabRepository
    {
        private readonly IDbConnections _dbConn;

        public GitlabRepository(IDbConnections dbConn) => _dbConn = dbConn;

        public async Task<IEnumerable<Group>> GetGroupsInfo()
        {
            await using var connection = _dbConn.PgConnection();
            return await connection.QueryAsync<Group>(GitlabQueries.GetGroupsInfo);
        }

        public async Task<IEnumerable<User>> GetUsersInfo()
        {
            await using var connection = _dbConn.PgConnection();
            return await connection.QueryAsync<User>(GitlabQueries.GetUsersInfo);
        }

        public async Task<IEnumerable<Project>> GetProjectsInfo()
        {
            await using var connection = _dbConn.PgConnection();
            return await connection.QueryAsync<Project>(GitlabQueries.GetProjectsInfo);
        }
    }
}