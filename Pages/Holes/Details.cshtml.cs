using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Holes
{
    public class DetailsModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DetailsModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public Hole Hole { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hole = await _context.Hole
                .Include(h => h.Drill).FirstOrDefaultAsync(m => m.ID == id);

            Hole = await _context.Hole
                .Include(h => h.HoleStatus).FirstOrDefaultAsync(m => m.ID == id);

            if (Hole == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
