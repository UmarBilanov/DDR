using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondDrillingReport.Models
{
    public class CreateDailyReport
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the Date.")]
        [Display(Name = "DATE")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please enter hole code.")]
        [Display(Name = "HOLE CODE")]
        public int HoleID { get; set; }
        public Hole Hole { get; set; }
        [Display(Name = "USER EMAIL")]
        public string User { get; set; }

        [Display(Name = "DAY EQUIPMENT")]
        public int EquipmentID { get; set; }
        [Display(Name = "NIGHT EQUIPMENT")]
        public int EquipmentNID { get; set; }
        public Equipment Equipment { get; set; }
        [Display(Name = "BITS DAY")]
        public string BitsDay { get; set; }
        [Display(Name = "BITS NIGHT")]
        public string BitsNight { get; set; }
        [Display(Name = "SHELL DAY")]
        public string ShellDay { get; set; }
        [Display(Name = "SHELL NIGHT")]
        public string ShellNight { get; set; }
        [Display(Name = "HOLE DEPTH TO DAY")]
        public decimal HoleDepthToDay { get; set; }
        [Display(Name = "HOLE DEPTH TO NIGHT")]
        public decimal HoleDepthToNight { get; set; }
        [Display(Name = "METERS DRILLED DAY")]
        public double MetersDrilledDay { get; set; }
        [Display(Name = "METERS DRILLED NIGHT")]
        public double MetersDrilledNight { get; set; }
        [Display(Name = "CASING TO DAY")]
        public double CasingToDay { get; set; }
        [Display(Name = "CASING TO NIGHT")]
        public double CasingToNight { get; set; }

        [Display(Name = "DAY CREW")]
        public int CrewID { get; set; }
        [Display(Name = "NIGHT CREW")]
        public int CrewNID { get; set; }
        public Crew Crew { get; set; }


        [Display(Name = "Pre Start Day")]
        public double PreStartDay { get; set; }
        [Display(Name = "Pre Start Night")]
        public double PreStartNight { get; set; }
        [Display(Name = "Condition Day")]
        public double ConditionDay { get; set; }
        [Display(Name = "Condition Night")]
        public double ConditionNight { get; set; }
        [Display(Name = "Drilling Day")]
        public double DrillingDay { get; set; }
        [Display(Name = "Drilling Night")]
        public double DrillingNight { get; set; }
        [Display(Name = "Reaming Day")]
        public double ReamingDay { get; set; }
        [Display(Name = "Reaming Night")]
        public double ReamingNight { get; set; }
        [Display(Name = "Reaming Casing Day")]
        public double ReamingCasingDay { get; set; }
        [Display(Name = "Reaming Casing Night")]
        public double ReamingCasingNight { get; set; }
        [Display(Name = "Bit Change Day")]
        public double BitChangeDay { get; set; }
        [Display(Name = "Bit Change Night")]
        public double BitChangeNight { get; set; }
        [Display(Name = "Repairs Day")]
        public double RepairsDay { get; set; }
        [Display(Name = "Repairs Night")]
        public double RepairsNight { get; set; }
        [Display(Name = "Blast Day")]
        public double BlastDay { get; set; }
        [Display(Name = "Blast Night")]
        public double BlastNight { get; set; }
        [Display(Name = "Water Delay Day")]
        public double WaterDelayDay { get; set; }
        [Display(Name = "Water Delay Night")]
        public double WaterDelayNight { get; set; }
        [Display(Name = "Awaiting Parts Materials Day")]
        public double AwaitingPartsMaterialsDay { get; set; }
        [Display(Name = "Awaiting Parts Materials Night")]
        public double AwaitingPartsMaterialsNight { get; set; }
        [Display(Name = "Awaiting Mechanic Electrician Day")]
        public double AwaitingMechanicElectricianDay { get; set; }
        [Display(Name = "Awaiting Mechanic Electrician Night")]
        public double AwaitingMechanicElectricianNight { get; set; }
        [Display(Name = "Awaiting Dozer Day")]
        public double AwaitingDozerDay { get; set; }
        [Display(Name = "Awaiting Dozer Night")]
        public double AwaitingDozerNight { get; set; }
        [Display(Name = "Preparation Drilling Day")]
        public double PreparationDrillingDay { get; set; }
        [Display(Name = "Preparation Drilling Night")]
        public double PreparationDrillingNight { get; set; }
        [Display(Name = "Dismantling Day")]
        public double DismantlingDay { get; set; }
        [Display(Name = "Dismantling Night")]
        public double DismantlingNight { get; set; }
        [Display(Name = "Moving Rig Day")]
        public double MovingRigDay { get; set; }
        [Display(Name = "Moving Rig Night")]
        public double MovingRigNight { get; set; }
        [Display(Name = "Testing Day")]
        public double TestsDay { get; set; }
        [Display(Name = "Testing Night")]
        public double TestsNight { get; set; }
        [Display(Name = "Awaiting Drill Crew Day")]
        public double AwaitingDrillCrewDay { get; set; }
        [Display(Name = "Awaiting Drill Crew Night")]
        public double AwaitingDrillCrewNight { get; set; }

        public double TestDayDepth { get; set; }
        public double TestDayDIP { get; set; }
        public double TestDayAZ { get; set; }
        public double TestDayMAG { get; set; }
        public double TestDayDepth2 { get; set; }
        public double TestDayDIP2 { get; set; }
        public double TestDayAZ2 { get; set; }
        public double TestDayMAG2 { get; set; }
        public double TestDayDepth3 { get; set; }
        public double TestDayDIP3 { get; set; }
        public double TestDayAZ3 { get; set; }
        public double TestDayMAG3 { get; set; }
        public double TestDayDepth4 { get; set; }
        public double TestDayDIP4 { get; set; }
        public double TestDayAZ4 { get; set; }
        public double TestDayMAG4 { get; set; }

        public double TestNightDepth { get; set; }
        public double TestNightDIP { get; set; }
        public double TestNightAZ { get; set; }
        public double TestNightMAG { get; set; }
        public double TestNightDepth2 { get; set; }
        public double TestNightDIP2 { get; set; }
        public double TestNightAZ2 { get; set; }
        public double TestNightMAG2 { get; set; }
        public double TestNightDepth3 { get; set; }
        public double TestNightDIP3 { get; set; }
        public double TestNightAZ3 { get; set; }
        public double TestNightMAG3 { get; set; }
        public double TestNightDepth4 { get; set; }
        public double TestNightDIP4 { get; set; }
        public double TestNightAZ4 { get; set; }
        public double TestNightMAG4 { get; set; }

        public string CommentDay { get; set; }
        public string CommentNight { get; set; }

        public static implicit operator CreateDailyReport(List<CreateDailyReport> v)
        {
            throw new NotImplementedException();
        }
    }
}
