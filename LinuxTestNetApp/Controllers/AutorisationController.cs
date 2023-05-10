using LinuxTestNetApp.Model.Abstractions.Types;
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

        [HttpGet]
        [Route("/Authorisation")]
        public IActionResult ShowAuthoriseForm()
        {

        }


        [HttpPost]
        [Route("/Registration")]
        public IActionResult Registrate(string login, string password)
        {
            
        }
        [HttpPost]
        [Route("/Registration")]
        public IActionResult Authorise(AuthorisationUser user)
        {
            if(user == null)
            {
                
            }
        }

    }
}
