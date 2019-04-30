using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class Drill
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter drill code.")]
        [Display(Name = "DRILL CODE")]
        public string DrillCode { get; set; }
        [Display(Name = "DRILL NUMBER")]
        public string DrillNum { get; set; }
        [Display(Name = "DRILL COLOUR")]
        public string DrillColour { get; set; }
        [Display(Name = "MODIFICATION")]
        public string Modification { get; set; }
        [Required(ErrorMessage = "Please enter drill name.")]
        [Display(Name = "DRILL NAME")]
        public string DrillName { get; set; }
        [Display(Name = "DEPTH")]
        public double Depth { get; set; }

        public ICollection<Hole> Holes { get; set; }
    }
}
