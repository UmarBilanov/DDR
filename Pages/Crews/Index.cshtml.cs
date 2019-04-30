using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Crews
{
    public class IndexModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<Crew> Crew { get; set; }
        public IList<Employee> Employee { get; set; }

        public async Task OnGetAsync()
        {
            Crew = await _context.Crew
                .Include(c => c.Employee).ToListAsync();

            Employee = await _context.Employee.ToListAsync();
        }
    }
}
