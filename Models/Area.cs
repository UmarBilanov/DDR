using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class Area
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter area name.")]
        public string Name { get; set; }

        public ICollection<HoleZone> HoleZones { get; set; }
    }
}
