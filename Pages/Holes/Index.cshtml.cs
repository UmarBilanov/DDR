using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Holes
{
    public class IndexModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<Hole> Hole { get;set; }

        public async Task OnGetAsync()
        {
            Hole = await _context.Hole
                .Include(h => h.Drill).ToListAsync();

            Hole = await _context.Hole
                .Include(h => h.HoleStatus).ToListAsync();

            Hole = await _context.Hole
                .Include(h => h.HoleZone)
                .Include(h => h.HoleZone.Area).ToListAsync();
        }
    }
}
