using System.ComponentModel.DataAnnotations.Schema;

namespace RESTfulAPI.Models
{
    public class ProjectTeam
    {
        public int ProjectId { get; set; }
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }
    }
}
