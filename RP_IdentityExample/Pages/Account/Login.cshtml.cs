using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RP_IdentityExample.MockLoginData;
using RP_IdentityExample.Models;

namespace RP_IdentityExample.Pages.Account
{
    public class LoginModel : PageModel
    {
         [BindProperty]public Credential credential { get; set; }   
        public LoginModel()
        {   }
        public void OnGet()
        {   }
        public async Task<IActionResult>  OnPostAsync() 
        {
            if (!ModelState.IsValid)    { return Page();  }
            else
            {
                if (MockCredentials.CheckCredentails(credential.Username, credential.Password))
                {
                    Claim claim1 = new Claim(ClaimTypes.Name, credential.Username);
                    Claim claim2 = new Claim(ClaimTypes.Role, "Student");
                    Claim claim3 = new Claim(ClaimTypes.Role, "Teacher");

                    
                    List<Claim> Claims = new List<Claim>() { claim1, claim2, claim3};

                    ClaimsIdentity identity = new ClaimsIdentity(Claims, "CookiesStudentAuth");

                    // create the user
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    // we need to encrypt and serialize the coockie, this is done using the httpContext.SignInAsync extension method
                    await HttpContext.SignInAsync("CookiesStudentAuth" , claimsPrincipal);

                    return RedirectToPage("/index");
                }
                else return Page();
            }                      
        }
    }
}
