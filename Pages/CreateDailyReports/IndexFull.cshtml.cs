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
    public class IndexFullModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexFullModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<CreateDailyReport> CreateDailyReport { get;set; }
        public SelectList Holes;

        public async Task OnGetAsync()
        {
           CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Equipment).ToListAsync();

            CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Crew).ToListAsync();

            CreateDailyReport = await _context.CreateDailyReport.ToListAsync();

        }

        
    }
}
