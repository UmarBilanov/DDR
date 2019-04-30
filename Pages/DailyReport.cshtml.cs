using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondDrillingReport.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;

namespace DiamondDrillingReport.Pages
{
    public class DailyReportModel : PageModel
    {

        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DailyReportModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<CreateDailyReport> CreateDailyReport { get; set; }
        public IList<Hole> Hole { get; set; }
        public IList<DrillProgram> DrillProgram { get; set; }
        public DateTime ReportDate { get; set; }
        public string culture { get; set; }


        public async Task OnGetAsync(DateTime ReportDate, string culture)
        {
            var dates = from d in _context.CreateDailyReport
                select d;

            dates = dates.Where(c => c.Date == ReportDate);

            CreateDailyReport = await _context.CreateDailyReport
                     .Include(c => c.Hole).ToListAsync();

            Hole = await _context.Hole
                .Include(h => h.Drill).ToListAsync();

            Hole = await _context.Hole
                .Include(h => h.HoleZone.Area).ToListAsync();

            Hole = await _context.Hole
                .Include(h => h.DrillProgram).ToListAsync();

            DrillProgram = await _context.DrillProgram.ToListAsync();

            CreateDailyReport = await dates.OrderBy(o => o.Hole.DrillProgram.Name).ToListAsync();

        }

    }
}
