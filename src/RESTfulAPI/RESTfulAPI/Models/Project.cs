using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RESTfulAPI.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Details { get; set; }

        public ICollection<Task> Tasks { get; set; } = new List<Task>();
        public ICollection<ProjectTeam> ProjectTeams { get; set; } = new List<ProjectTeam>();
    }
}
