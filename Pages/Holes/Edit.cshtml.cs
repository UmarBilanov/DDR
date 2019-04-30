using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Holes
{
    public class EditModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public EditModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hole Hole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hole = await _context.Hole
                .Include(h => h.Drill).FirstOrDefaultAsync(m => m.ID == id);

            if (Hole == null)
            {
                return NotFound();
            }

            ViewData["HoleZoneID"] = new SelectList(_context.HoleZone.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["DrillID"] = new SelectList(_context.Drill.Select(x => new { Value = x.ID, Text = x.DrillCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["DrillProgramID"] = new SelectList(_context.DrillProgram.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["HoleStatusID"] = new SelectList(_context.HoleStatus.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || HoleCodeExists(Hole.HoleCode) == true && HoleExists(Hole.ID) == false || Hole.HoleStartDate > Hole.HoleEndDate)
            {
                ViewData["HoleZoneID"] = new SelectList(_context.HoleZone.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["DrillID"] = new SelectList(_context.Drill.Select(x => new { Value = x.ID, Text = x.DrillCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["DrillProgramID"] = new SelectList(_context.DrillProgram.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["HoleStatusID"] = new SelectList(_context.HoleStatus.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

                //if (HoleCodeExists(Hole.HoleCode) == true && HoleExists(Hole.ID) == true)
                //{
                //    ViewData["Message"] = $"Hole Code {Hole.HoleCode} already exists";
                //}
                if (HoleCodeExists(Hole.HoleCode) == true && HoleExists(Hole.ID) == false)
                {
                    ViewData["Message"] = $"Hole Code {Hole.HoleCode} already exists";
                }

                if (Hole.HoleStartDate > Hole.HoleEndDate)
                {
                    ViewData["DateValid"] = $"Hole Start Date must be before than Hole End Date.";
                }

                return Page();

            }

            _context.Attach(Hole).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoleExists(Hole.ID))
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

        private bool HoleExists(int id)
        {
            return _context.Hole.Any(e => e.ID == id);
        }

        private bool HoleCodeExists(string holecode)
        {
            return _context.Hole.Any(e => e.HoleCode == holecode);
        }
    }
}
