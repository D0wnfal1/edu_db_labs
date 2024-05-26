using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RESTfulAPI.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
        
        public ICollection<ProjectTeam> ProjectTeams { get; set; } = new List<ProjectTeam>();
    }
}
