using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter asset code.")]
        [Display(Name = "ASSET CODE")]
        public string AssetCode  { get; set; }

        [Required(ErrorMessage = "Please enter watertruck name.")]
        [Display(Name = "WATERTRUCK NAME")]
        public string WatertruckName { get; set; }

        [Required(ErrorMessage = "Please enter hull number.")]
        [Display(Name = "HULL NUMBER")]
        public int HullNumber { get; set; }

        public ICollection<CreateDailyReport> CreateDailyReports { get; set; }
    }
}
