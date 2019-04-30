using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DiamondDrillingReport.Models
{
    public enum Position
    {
        Drill_Foreman,
        Drill_Operator,
        Drill_Helper
    }

    //public enum Status
    //{
    //    [Display(Name = "Active")]
    //    Active,
    //    [Display(Name = "No Active")]
    //    NoActive,
    //}

    public class Employee
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter employee code.")]
        [Display(Name = "EMPLOYEE CODE")]
        public string EmployeeCode { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        [Display(Name = "NAME")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter surname.")]
        [Display(Name = "SURNAME")]
        public string Surname { get; set; }

        [Display(Name = "SHORT NAME")]
        public string Short
        {
            get
            {
                if (!string.IsNullOrEmpty(Surname))
                {
                    return Surname + " " + Name.Substring(0, 1) + ".";

                }
                else
                {
                    return "";
                }
            }
        }

        [Required(ErrorMessage = "Please enter russian name.")]
        [Display(Name = "NAME RUS")]
        public string NameRus { get; set; }

        [Required(ErrorMessage = "Please select the position.")]
        [Display(Name = "POSITION")]
        public Position Position { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select the start date.")]
        [Display(Name = "START DATE")]
        public DateTime StartDate { get; set; }

        [Display(Name = "END DATE")]
        public DateTime? EndDate { get; set; }

        
        [Required(ErrorMessage = "Please enter Company.")]
        [Display(Name = "COMPANY")]
        public string Company { get; set; }

        public ICollection<Crew> Crews { get; set; }
    }
}
