using AMS.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AMS.Web.Pages.Accounts
{
    public class CreateAccountModel : PageModel
    {
        private IAccountService _accountService;
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
        [BindProperty]
        public Guid? ParentAccountId { get; set; }
        public CreateAccountModel(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _accountService.CreateNewAccount(Name,UserType, AccountType, Cash,Recieveable,ParentAccountId);
            return RedirectToPage("/");
        }
    }
}
