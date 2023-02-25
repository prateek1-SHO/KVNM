using System.ComponentModel.DataAnnotations;

namespace KVNM.Models.VillaDto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        
        public decimal squertFee { get; set; }
        [Required]
        
        public decimal price  { get; set; }
        public DateTime CreateDateTime { get; set; }

    }
}
