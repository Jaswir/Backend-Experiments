using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using EmployeeesWebAPI.Models.Domain;

namespace EmployeeesWebAPI.Models.Login
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
