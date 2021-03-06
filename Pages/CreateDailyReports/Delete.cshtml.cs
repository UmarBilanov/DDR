﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.CreateDailyReports
{
    public class DeleteModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DeleteModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CreateDailyReport CreateDailyReport { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CreateDailyReport = await _context.CreateDailyReport
                .Include(c => c.Hole).FirstOrDefaultAsync(m => m.ID == id);

            if (CreateDailyReport == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CreateDailyReport = await _context.CreateDailyReport.FindAsync(id);

            if (CreateDailyReport != null)
            {
                _context.CreateDailyReport.Remove(CreateDailyReport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
