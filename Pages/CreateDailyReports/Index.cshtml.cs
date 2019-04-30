using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace DiamondDrillingReport.Pages.CreateDailyReports
{
    public class IndexModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<CreateDailyReport> CreateDailyReport { get;set; }
        public SelectList Holes;
        public string HoleString { get; set; }
        public DateTime RDateTime  { get; set; }

        public async Task OnGetAsync(string HoleString, DateTime? RDateTime)
        {
           Holes = new SelectList(_context.Hole, "HoleCode", "HoleCode");

            var holes = from h in _context.CreateDailyReport
                select h;

            CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Hole.Drill).ToListAsync();

            CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Equipment).ToListAsync();

            CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Crew).ToListAsync();

            if (string.IsNullOrEmpty(HoleString) && RDateTime == null)
            {
                CreateDailyReport = await holes.OrderBy(o => o.Date).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(HoleString) && RDateTime == null)
            {
                //holes = holes.Where(s => s.Hole.HoleCode == HoleString);
                CreateDailyReport = await holes.Where(s => s.Hole.HoleCode == HoleString).OrderByDescending(o => o.Date).ToListAsync();
            }
            else if (!string.IsNullOrEmpty(HoleString) && !string.IsNullOrEmpty(RDateTime.ToString()))
            {
                //holes = holes.Where(s => s.Hole.HoleCode == HoleString).Where(d => d.Date == RDateTime);
                CreateDailyReport = await holes.Where(s => s.Hole.HoleCode == HoleString).Where(d => d.Date == RDateTime).ToListAsync();
            }
        }

    }

    public class async
    {
    }
}
