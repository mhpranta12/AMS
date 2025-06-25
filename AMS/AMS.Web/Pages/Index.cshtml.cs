using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AMS.Web.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }
        
        public IActionResult OnPost()
        {
            return RedirectToPage();
        }
    }
}
