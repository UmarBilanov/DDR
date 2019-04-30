using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace DiamondDrillingReport.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnGetSetCulture(string culture)
        {
            HttpContext.Response.Cookies.Append("Culture", "c=" + culture + "|uic=" + culture);
            var returnUrl = Request.Headers["Referer"].ToString();
            if (returnUrl.Contains("?culture="))
            {
                var url = returnUrl.Substring(0, returnUrl.IndexOf("?culture="));
                return Redirect(url + "?culture=" + culture);
            }
            else
            {
                return Redirect(returnUrl + "?culture=" + culture);
            }
            
        }
        
        //public string culture { get; set; }

        //[HttpPost]
        //public IActionResult SetLanguage(string culture, string returnUrl)
        //{
        //    Response.Cookies.Append(
        //        CookieRequestCultureProvider.DefaultCookieName,
        //        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
        //        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        //    );

        //    return LocalRedirect(returnUrl);
        //}
    }
}
