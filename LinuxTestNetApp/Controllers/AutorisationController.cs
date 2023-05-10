using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinuxTestNetApp.Controllers
{
    [Controller]
    [Route("/")]
    public class AutorisationController : Controller
    {
        [HttpGet]
        [Route("/Registration")]
        public IActionResult ShowRegistrateForm()
        {
            return View();
        }

        [HttpPost]
        [Route("/Registration")]
        public IActionResult Registrate(string login, string password)
        {
            
        }

        [HttpGet]
        [Route("/Authorisation")]
        public IActionResult ShowAuthoriseForm()
        {
            
        }

    }
}
