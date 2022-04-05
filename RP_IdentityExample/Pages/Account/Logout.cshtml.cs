using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RP_IdentityExample.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync("CookiesStudentAuth");
            return RedirectToPage("/index");
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    await HttpContext.SignOutAsync("CookiesStudentAuth");
        //    return RedirectToPage("/index");
        //}
    }
}
