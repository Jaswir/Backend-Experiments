using Microsoft.AspNetCore.Mvc;

namespace MainService.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            return Redirect("http://localhost:5001/");
        }

    
    }
}
