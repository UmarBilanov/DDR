using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DiamondDrillingReport.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DiamondDrillingReport.Pages.Holes
{
    public class CreateModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public CreateModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }
        //ViewData["HoleID"] = new SelectList(_context.Hole.Select(x => new { Value = x.ID, Text = x.HoleCode
        //}).OrderBy(s => s.Text), "Value", "Text");
        
        public IActionResult OnGet()
        {
            ViewData["HoleZoneID"] = new SelectList(_context.HoleZone.Select(x => new { Value = x.ID, Text = x.Name}).OrderBy(s => s.Text), "Value", "Text");
            ViewData["DrillID"] = new SelectList(_context.Drill.Select(x => new { Value = x.ID, Text = x.DrillCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["DrillProgramID"] = new SelectList(_context.DrillProgram.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["HoleStatusID"] = new SelectList(_context.HoleStatus.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

            //PopulateDrillsDropDownList(_context);

            return Page();
        }


        [BindProperty]
        public Hole Hole { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || HoleCodeExists(Hole.HoleCode) == true || Hole.HoleStartDate > Hole.HoleEndDate)
            {
                ViewData["HoleZoneID"] = new SelectList(_context.HoleZone.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["DrillID"] = new SelectList(_context.Drill.Select(x => new { Value = x.ID, Text = x.DrillCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["DrillProgramID"] = new SelectList(_context.DrillProgram.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["HoleStatusID"] = new SelectList(_context.HoleStatus.Select(x => new { Value = x.ID, Text = x.Name }).OrderBy(s => s.Text), "Value", "Text");

                if (HoleCodeExists(Hole.HoleCode) == true)
                {
                    ViewData["Message"] = $"Hole Code {Hole.HoleCode} already exists";
                }

                if (Hole.HoleStartDate > Hole.HoleEndDate)
                {
                    ViewData["DateValid"] = $"Hole Start Date must be before than Hole End Date.";
                }

                return Page();

            }

            _context.Hole.Add(Hole);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private bool HoleCodeExists(string holecode)
        {
            return _context.Hole.Any(e => e.HoleCode == holecode);
        }   
    }
}