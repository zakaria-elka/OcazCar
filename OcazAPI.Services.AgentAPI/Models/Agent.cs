
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OcazAPI.Services.AgentAPI.Models
{
    [Table("Agents")]
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        [Required, StringLength(25)]
        public string AgentName { get; set; }
        public string AgentPhone { get; set; }
        public string AgentPas { get; set; }
  

    }
}
