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
    public class IndexModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public IndexModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        public IList<Area> Area { get;set; }
        

        public async Task OnGetAsync()
        {
            Area = await _context.Area.ToListAsync();
        }
    }
}
