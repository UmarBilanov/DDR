using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiamondDrillingReport.Models;

namespace DiamondDrillingReport.Pages.CreateDailyReports
{
    public class EditModel : PageModel
    {
        private readonly DiamondDrillingReport.Models.DiamondDrillingReportContext _context;

        public EditModel(DiamondDrillingReport.Models.DiamondDrillingReportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CreateDailyReport CreateDailyReport { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, DateTime date, int? holeid)
        {

            if (id == null && date == null && holeid == null)
            {
                return NotFound();
            }

            if (date != null && holeid != null)
            {
                foreach (var i in _context.CreateDailyReport)
                {
                    if (i.Date.Date == date)
                    {
                        if (i.HoleID == holeid)
                        {
                            CreateDailyReport = i;
                            break;
                        }
                    }

                }
            }


            if (id != null)
            {

                CreateDailyReport = await _context.CreateDailyReport
                    .Include(c => c.Hole).FirstOrDefaultAsync(m => m.ID == id);
            }



            if (CreateDailyReport == null)
            {
                return Page().Page.Content(NotFoundPage(),"html",Encoding.UTF8);
            }

            ViewData["HoleID"] = new SelectList(_context.Hole.Select(x => new { Value = x.ID, Text = x.HoleCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["EquipmentDayID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["EquipmentNightID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["CrewDayID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");
            ViewData["CrewNightID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");
            return Page();
        }
      

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ViewData["HoleID"] = new SelectList(_context.Hole.Select(x => new { Value = x.ID, Text = x.HoleCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["EquipmentDayID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["EquipmentNightID"] = new SelectList(_context.Equipment.Select(x => new { Value = x.ID, Text = x.AssetCode }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["CrewDayID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");
                ViewData["CrewNightID"] = new SelectList(_context.Crew.Select(x => new { Value = x.ID, Text = x.CrewName }).OrderBy(s => s.Text), "Value", "Text");

                return Page();
            }

            _context.Attach(CreateDailyReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreateDailyReportExists(CreateDailyReport.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CreateDailyReportExists(int id)
        {
            return _context.CreateDailyReport.Any(e => e.ID == id);
        }

        public string NotFoundPage()
        {
            var html ="<html><head>    <meta charset=\"utf-8\">    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">    <title>Home page - DiamondDrillingReport</title>            <link rel=\"stylesheet\" href=\"/lib/bootstrap/dist/css/bootstrap.css\">        <link rel=\"stylesheet\" href=\"/css/site.css\">        </head><body>    <nav class=\"navbar navbar-inverse navbar-fixed-top\">        <div class=\"container\">            <div class=\"navbar-header\">                <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">                    <span class=\"sr-only\">Toggle navigation</span>                    <span class=\"icon-bar\"></span>                    <span class=\"icon-bar\"></span>                    <span class=\"icon-bar\"></span>                </button>                <a class=\"navbar-brand\" href=\"/\">DiamondDrillingReport</a>            </div>        </div>    </nav>        <div class=\"container body-content\">        <hr><div class=\"container\">    <div class=\"col-sm-9\">        <h2 style=\"width: 100%; text-align:center;\">Данные по указанным параметрам не найдены</h2>        <div class=\"col-sm-1\"></div>        <div class=\"col-sm-10\">                    </div>        <div class=\"col-sm-1\"></div>    </div>    <div class=\"col-sm-3\">        <a href=\"/CreateDailyReports/Create\"><button type=\"button\" class=\"btn btn-block\">Create Daily Report</button></a><br>        <a href=\"/CreateDailyReports\"><button type=\"button\" class=\"btn btn-block\">Edit Daily Report</button></a><br>        <a href=\"/Holes/Create\"><button type=\"button\" class=\"btn btn-block\">Add Edit References</button></a><br>        <a href=\"/DailyReport\"><button type=\"button\" class=\"btn btn-block\">Daily Report</button></a><br>    </div></div>        <hr>        <footer>            <p>© 2019 - DiamondDrillingReport</p>        </footer>    </div>            <script src=\"/lib/jquery/dist/jquery.js\"></script>        <script src=\"/lib/bootstrap/dist/js/bootstrap.js\"></script>        <script src=\"/js/site.js?v=OEKXgI9PmNhlq2AUE25en6TUhF2eBPN3aK5liFeCM0w\"></script>        <script src=\"/js/site.min.js?v=5kWX4wD-wCMZOMGhqvcVpP1-7A4XQX_Ow5YLRtdYXSU\"></script>            </body></html>";
            return html;
        }
    }
}
