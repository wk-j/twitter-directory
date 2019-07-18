using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace TwitterDirectory.Controllers {
    [Route("api/[controller]/[action]")]
    public class AccountController : ControllerBase {
        private readonly HttpClient _client;

        public AccountController(HttpClient client) {
            _client = client;
        }

        [HttpGet]
        public IActionResult Process() {
            return Ok();
        }

        [HttpGet]
        public IActionResult Login() {
            return Ok();
        }
    }
}