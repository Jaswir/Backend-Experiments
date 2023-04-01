using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebShopApp2.Models.Domain;

namespace WebShopApp2.Models.Login
{
    public class LoginViewModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public User Model { get; set; }

        public LoginViewModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

    }

}
