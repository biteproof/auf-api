using System.Collections.Generic;
using System.Threading.Tasks;
using AufApi.Data.Models;

namespace AufApi.Data
{
    public interface IGitlabRepository
    {
        Task<IEnumerable<Group>> GetGroupsInfo();
        Task<IEnumerable<User>> GetUsersInfo();
        Task<IEnumerable<Project>> GetProjectsInfo();
    }
}