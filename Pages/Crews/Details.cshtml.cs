using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DiamondDrillingReport.Pages.Crews
{
    public class DetailsModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DetailsModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public Crew Crew { get; set; }

        public Employee Employee { get; set; }

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


            return Page();
        }
    }
}
