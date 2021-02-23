using System;

namespace AufApi.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public string State { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}