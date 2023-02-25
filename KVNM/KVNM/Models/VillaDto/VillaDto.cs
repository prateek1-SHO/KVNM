using System.ComponentModel.DataAnnotations;

namespace KVNM.Models.VillaDto
{
    public class VillaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Rate { get; set; }
        public string Sqft { get; set; }
        public string Occupancy { get; set; }
        public string IamgeURL { get; set; }
        public string Amenity { get; set; }

    }
}
