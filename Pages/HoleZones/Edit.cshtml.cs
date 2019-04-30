using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.HoleZones
{
    public class EditModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public EditModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HoleZone HoleZone { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HoleZone = await _context.HoleZone
                .Include(h => h.Area).FirstOrDefaultAsync(m => m.ID == id);

            if (HoleZone == null)
            {
                return NotFound();
            }

            ViewData["AreaID"] = new SelectList(_context.Area.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AreaID"] = new SelectList(_context.Area.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

                return Page();
            }

            _context.Attach(HoleZone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoleZoneExists(HoleZone.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HoleZoneExists(int id)
        {
            return _context.HoleZone.Any(e => e.ID == id);
        }
    }
}
