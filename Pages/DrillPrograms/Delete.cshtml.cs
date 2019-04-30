﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.DrillPrograms
{
    public class DeleteModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DeleteModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DrillProgram DrillProgram { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DrillProgram = await _context.DrillProgram.FirstOrDefaultAsync(m => m.ID == id);

            if (DrillProgram == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DrillProgram = await _context.DrillProgram.FindAsync(id);

            if (DrillProgram != null)
            {
                _context.DrillProgram.Remove(DrillProgram);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
