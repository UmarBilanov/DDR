using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.HoleZones
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
            ViewData["AreaID"] = new SelectList(_context.Area.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

            return Page();
        }

        [BindProperty]
        public HoleZone HoleZone { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["AreaID"] = new SelectList(_context.Area.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

                return Page();
            }

            _context.HoleZone.Add(HoleZone);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}