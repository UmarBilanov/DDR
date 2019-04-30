using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace DiamondDrillingReport.Models
{
    public class Hole
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter hole code.")]
        [Display(Name = "HOLE CODE")]
        //[Remote("CheckForDuplication", "/Holes/Create", HttpMethod = "POST", ErrorMessage = "User name already exists. Please enter a different user name.")]
        public string HoleCode { get; set; }
        
        [Required(ErrorMessage = "Please enter project code.")]
        [Display(Name = "PROJECT CODE")]
        public string ProjectCode { get; set; }

        [Required(ErrorMessage = "Please enter hole zone.")]
        [Display(Name = "HOLE ZONE")]
        public int HoleZoneID { get; set; }
        public HoleZone HoleZone { get; set; }

        [Required(ErrorMessage = "Please enter drill.")]
        [Display(Name = "DRILL")]
        public int DrillID { get; set; }
        public Drill Drill { get; set; }

        [Required(ErrorMessage = "Please enter drill program.")]
        [Display(Name = "DRILL PROGRAM")]
        public int DrillProgramID { get; set; }
        public DrillProgram DrillProgram { get; set; }

        [Required(ErrorMessage = "Please enter bench.")]
        [Display(Name = "BENCH")]
        public double Bench { get; set; }

        [Required(ErrorMessage = "Please enter project depth.")]
        [Display(Name = "PROJECT DEPTH")]
        public double HoleDepth { get; set; }

        [Required(ErrorMessage = "Please enter azimut.")]
        [Display(Name = "AZIMUT")]
        public double Azimut { get; set; }

        [Required(ErrorMessage = "Please enter dip.")]
        [Display(Name = "DIP")]
        public double Dip { get; set; }

        [Required(ErrorMessage = "Please enter section.")]
        [Display(Name = "SECTION")]
        public double Section { get; set; }
        
        [Display(Name = "ZERO DATUM")]
        public double ZeroDatum { get; set; }

        public DateTime today = DateTime.Now;

        [Required(ErrorMessage = "Please enter hole start date.")]
        [Display(Name = "HOLE START DATE")]
        //[Range(typeof(DateTime), "1/1/2000", DateTime.Parse(HoleEndDate.ToString(), Culture.InvariantCulture),
        //    ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [DataType(DataType.Date)]
        public DateTime HoleStartDate { get; set; }

        private DateTime _holeEndDate = DateTime.MaxValue;
        [Display(Name = "HOLE END DATE")]
        [DataType(DataType.Date)]
        public DateTime HoleEndDate
        {
            get
            {
                if (HoleStatusID == 2 || HoleStatusID == 3)
                {
                    return (_holeEndDate == DateTime.MaxValue) ? DateTime.Now : _holeEndDate;
                }
                else
                {
                    return (_holeEndDate);
                }
            }
            set { _holeEndDate = value; }
        }

        [Required(ErrorMessage = "Please enter hole status.")]
        [Display(Name = "HOLE STATUS")]
        public int HoleStatusID { get; set; }
        public HoleStatus HoleStatus { get; set; }

        [Display(Name = "HOLE COMMENT")]
        public string HoleComment { get; set; }

        [Required(ErrorMessage = "Please enter project coordinates x.")]
        [Display(Name = "PROJECT COORDINATES X")]
        public double ProjectCoordinatesX { get; set; }

        [Required(ErrorMessage = "Please enter project coordinates y.")]
        [Display(Name = "PROJECT COORDINATES Y")]
        public double ProjectCoordinatesY { get; set; }

        [Required(ErrorMessage = "Please enter project coordinates z.")]
        [Display(Name = "PROJECT COORDINATES Z")]
        public double ProjectCoordinatesZ { get; set; }

        [Required(ErrorMessage = "Please enter actual coordinate x.")]
        [Display(Name = "ACTUAL COORDINATE X")]
        [Range(0.000001, 999999999)]
        public double ActualCoordinateX { get; set; }

        [Required(ErrorMessage = "Please enter actual coordinate y.")]
        [Display(Name = "ACTUAL COORDINATE Y")]
        [Range(0.000001, 999999999)]
        public double ActualCoordinateY { get; set; }

        [Required(ErrorMessage = "Please enter actual coordinate z.")]
        [Display(Name = "ACTUAL COORDINATE Z")]
        [Range(0.000001, 999999999)]
        public double ActualCoordinateZ { get; set; }

        
        public ICollection<CreateDailyReport> CreateDailyReports { get; set; }

        public static implicit operator Hole(List<Hole> v)
        {
            throw new NotImplementedException();
        }
    }
}
