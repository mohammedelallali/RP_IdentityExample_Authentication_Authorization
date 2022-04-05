using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP_IdentityExample.Models;
using RP_IdentityExample.ViewModels;

namespace RP_IdentityExample.Pages.Account
{
    public class RegisterModel : PageModel
    {
        [BindProperty]  public RegisterViewModel  RegisterViewModel { get; set; }
        public RegisterModel()
        {  }
         public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (RegisterViewModel.Password == RegisterViewModel.ConfirmPassword)
                {
                    MockLoginData.MockCredentials.NewCredential(new Credential() { Username = RegisterViewModel.Email, Password = RegisterViewModel.Password });
                }
            }
            return Page();
        }
    }
}
