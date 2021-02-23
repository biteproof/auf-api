using System;

namespace AufApi.Data.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}