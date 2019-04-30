using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Crews
{
    public class CreateModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public CreateModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper1ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper2ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["Helper3ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
            return Page();
        }

        [BindProperty]
        public Crew Crew { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || CrewNameExists(Crew.CrewName) == true)
            {
                ViewData["EmployeeID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper1ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper2ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["Helper3ID"] = new SelectList(_context.Employee.Select(x => new { Value = x.ID, Text = x.Short + " " + x.EmployeeCode }).OrderBy(s => s.Text), "Value", "Text");

                if (CrewNameExists(Crew.CrewName) == true)
                {
                    ViewData["Message"] = $"Crew Name {Crew.CrewName} already exists";
                }


                return Page();

            }

            _context.Crew.Add(Crew);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");


        }

        private bool CrewNameExists(string crewname)
        {
            return _context.Crew.Any(e => e.CrewName == crewname);
        }

    }
}