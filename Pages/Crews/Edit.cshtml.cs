using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Crews
{
    public class EditModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public EditModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Crew Crew { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Crew = await _context.Crew
                .Include(c => c.Employee).FirstOrDefaultAsync(m => m.ID == id);

            if (Crew == null)
            {
                return NotFound();
            }

            ViewData["EmployeeID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper1ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper2ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper3ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["EmployeeID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper1ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper2ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper3ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");

                return Page();
            }

            _context.Attach(Crew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrewExists(Crew.ID))
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

        private bool CrewExists(int id)
        {
            return _context.Crew.Any(e => e.ID == id);
        }
    }
}
