using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace OcazAPI.Services.CarAPI.Models
{
    [Table("Cars")]
    public class Cars
    {
        [Key]
        public int CarId { get; set; }
        [Required, StringLength(25)]
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarTrans { get; set; }
        public string CarCarburant { get; set; }
        public string CarKm { get; set; }
        public string CarDesc { get; set; }
        [AllowNull]
        public byte[] CarImage { get; set; }  



    }
}

