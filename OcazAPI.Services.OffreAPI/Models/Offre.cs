using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OcazAPI.Services.OffreAPI.Models
{
    [Table("Offres")]
    public class Offre
    {
        [Key]
        public int OffreId { get; set; }
        [Required, StringLength(25)]
        public string OffreCarName { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
        public string DatePub { get; set; }
        public string Ville { get; set; }
        public int AgentId { get; set; }
        public int CarId { get; set; }

    }
}

