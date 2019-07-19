using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace TwitterDirectory.Controllers {
    [Route("[controller]/[action]")]
    public class AccountController : Controller {
        public IActionResult Login(string returnUrl = "/Home/Index") {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl }, "Twitter");
        }
    }
}