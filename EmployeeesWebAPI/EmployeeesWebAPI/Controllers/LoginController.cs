using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeeesWebAPI.Data;
using EmployeeesWebAPI.Models.Domain;

namespace EmployeeesWebAPI.Controllers
{
    public class LoginController : Controller
    {

        public ApplicationDbContext ApplicationDbContext { get; }

        private readonly SignInManager<IdentityUser> signInManager;


        public LoginController(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;

           
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // Post
        [HttpPost]
        public async Task<IActionResult> Login(User givenUser)
        {

            //Search if username and password exists
            var users = await ApplicationDbContext.Users.ToListAsync();
            bool validUser = users.Find(x => x.Username == givenUser.Username && x.Password == givenUser.Password) != null;

            //Login ..?? Display boolean that says login I suppose


            return RedirectToAction("Index", "Home");
        }



    }
}
