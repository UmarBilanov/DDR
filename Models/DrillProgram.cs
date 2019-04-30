using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class DrillProgram
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter drill program name.")]
        [Display(Name = "NAME")]
        public string Name { get; set; }

        public ICollection<Hole> Holes { get; set; }
    }
}
