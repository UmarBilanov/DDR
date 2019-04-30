using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class Crew
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter crew name.")]
        [Display(Name = "CREW CODE")]
        public string CrewName { get; set; }

        [Required(ErrorMessage = "Please enter operator.")]
        [Display(Name = "OPERATOR")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter helper 1.")]
        [Display(Name = "HELPER 1")]
        public int Helper1ID { get; set; }
        
        [Display(Name = "HELPER 2")]
        public int Helper2ID { get; set; }

        [Display(Name = "HELPER 3")]
        public int Helper3ID { get; set; }
        
        public Employee Employee { get; set; }

        public ICollection<CreateDailyReport> CreateDailyReports { get; set; }
    }
}
