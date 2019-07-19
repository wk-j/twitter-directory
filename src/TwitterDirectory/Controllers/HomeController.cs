using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TwitterDirectory.Controllers {
    // [Route("[controller]/[action]")]
    [Authorize(AuthenticationSchemes = "Twitter")]
    public class HomeController : Controller {
        public IActionResult Index() => View();
        public IActionResult Error() => View();
    }
}