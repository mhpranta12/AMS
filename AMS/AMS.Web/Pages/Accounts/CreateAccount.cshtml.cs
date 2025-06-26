using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AMS.Web.Pages.Accounts
{
    public class CreateAccountModel : PageModel
    {
        public Guid Id { get; set; }
        [BindProperty]
        [Required]
        public string Name { get; set; }
        [BindProperty]
        public string? UserType { get; set; }
        [BindProperty]
        public string? AccountType { get; set; }
        [BindProperty]
        public decimal? Cash { get; set; }
        [BindProperty]
        public decimal? Recieveable { get; set; }
        public Guid? ParentAccountId { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}
