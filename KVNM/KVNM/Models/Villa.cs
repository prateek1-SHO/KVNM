using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KVNM.Models
{
    [Table("Villas")]
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string  Name { get; set;}       
        public string Details { get; set;}
        public string Rate { get; set;}
        public string Sqft { get; set;}
        public string Occupancy { get; set;}
        public string IamgeURL { get; set;}
        public string Amenity   { get; set;}
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
