using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class HoleZone
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter hole zone name.")]
        [Display(Name = "NAME")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose a area.")]
        [Display(Name = "AREA")]
        public int AreaID { get; set; }
        public Area Area { get; set; }

        public ICollection<Hole> Holes { get; set; }
    }
}
