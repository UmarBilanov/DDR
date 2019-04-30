﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.HoleZones
{
    public class IndexModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<HoleZone> HoleZone { get;set; }

        public async Task OnGetAsync()
        {
            HoleZone = await _context.HoleZone
                .Include(h => h.Area).ToListAsync();
        }
    }
}
