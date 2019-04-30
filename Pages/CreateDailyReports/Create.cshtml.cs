using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DiamondDrillingReport.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DiamondDrillingReport.Pages.CreateDailyReports
{
    public class CreateModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public CreateModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }
        
        public IList<CreateDailyReport> CreateDailyReports { get; set; }
        public IList<Crew> Crew { get; set; }
        public IList<Employee> Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(DateTime date, int? holeId)
        {
            var dates = from d in _context.CreateDailyReport
                select d;

            //var q = from createDailyReport in dates
            //    group createDailyReport by createDailyReport.HoleDepthToNight
            //    into g
            //    select new { HoleDepthToNight = g.Key, Date = g.Max(t => t.Date) };
            //ViewData["HoleDepthFromDay"] = q;

            //if (!string.IsNullOrEmpty(Request.Form["holeID"]))
            //{
            //    if (Request.Form["holeID"] == CreateDailyReport.HoleID)
            //    {


            //        ViewData["HoleDepthFromDay"] = q;
            //    }
            //    //ViewData["HoleDepthFromDay"] = dates.Where(s => s.HoleID == holeId).Where(s => s.Date.ToString() == CreateDailyReport.Date.ToString().Max());
            //}

            //dates = dates.Where(c => c.Date.Max());

            if (date != null && holeId != null)
            {
                foreach (var i in _context.CreateDailyReport)
                {
                    if (i.Date.Date == date)
                    {
                        if (i.HoleID == holeId)
                        {
                            CreateDailyReport = i;
                            break;
                        }
                    }

                }
            }
            
            Crew = await _context.Crew
                .Include(c => c.Employee).ToListAsync();

            Employee = await _context.Employee.ToListAsync();

            ViewData["HoleID"] = new SelectList(_context.Hole.Select(x => new { Value = x.ID, Text = x.HoleCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["EquipmentDayID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["EquipmentNightID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["CrewDayID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["CrewNightID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");

            return Page();

        }

        [BindProperty]
        public CreateDailyReport CreateDailyReport { get; set; }
        public object Date { get; private set; }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid || CreateDailyReportExists(CreateDailyReport.HoleID, CreateDailyReport.Date) == true)
            {
                ViewData["HoleID"] = new SelectList(_context.Hole.Select(x => new { Value = x.ID, Text = x.HoleCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["EquipmentDayID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["EquipmentNightID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["CrewDayID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["CrewNightID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");

                if (CreateDailyReportExists(CreateDailyReport.HoleID, CreateDailyReport.Date) == true)
                {
                    ViewData["Message"] = $"We already have a report with this hole for {CreateDailyReport.Date}.";
                }
                
                return Page();

            }

            _context.CreateDailyReport.Add(CreateDailyReport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool CreateDailyReportExists(int holeID, DateTime DateTime)
        {
            return _context.CreateDailyReport.Any(e => e.HoleID == holeID && e.Date == DateTime);
        }
    }
}