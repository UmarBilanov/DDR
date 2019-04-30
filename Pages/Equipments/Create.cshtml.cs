using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DiamondDrillingReport.Models;
using System.Linq;

namespace DiamondDrillingReport.Pages.Equipments
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
            return Page();
        }

        [BindProperty] 
        public Equipment Equipment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || AssetCodeExists(Equipment.AssetCode) == true)
            {
                if (AssetCodeExists(Equipment.AssetCode) == true)
                {
                    ViewData["Message"] = $"Asset Code {Equipment.AssetCode} already exists";
                }
                return Page();
            }

            _context.Equipment.Add(Equipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool AssetCodeExists(string assetcode)
        {
            return _context.Equipment.Any(e => e.AssetCode == assetcode);
        }
    }
}