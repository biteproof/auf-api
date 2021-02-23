using System.Collections.Generic;
using System.Threading.Tasks;
using AufApi.Data;
using AufApi.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AufApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitlabController : ControllerBase
    {
        private readonly ILogger<GitlabController> _logger;
        private readonly IGitlabRepository _gitlabRepo;

        public GitlabController(ILogger<GitlabController> logger, IGitlabRepository gitlabRepo)
        {
            _logger = logger;
            _gitlabRepo = gitlabRepo;
        }

        [HttpGet]
        [Route("/gitlab/groups")]
        public async Task<IEnumerable<Group>> GetGroups()
        {
            var res = await _gitlabRepo.GetGroupsInfo();
            return res;
        }
        
        [HttpGet]
        [Route("/gitlab/users")]
        public async Task<IEnumerable<User>> GetUsers()
        {
            var res = await _gitlabRepo.GetUsersInfo();
            return res;
        }
        
        [HttpGet]
        [Route("/gitlab/projects")]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            var res = await _gitlabRepo.GetProjectsInfo();
            return res;
        }
    }
}