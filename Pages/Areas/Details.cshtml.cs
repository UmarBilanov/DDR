﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.Areas
{
    public class DetailsModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public DetailsModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public Area Area { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Area = await _context.Area.FirstOrDefaultAsync(m => m.ID == id);

            if (Area == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
