using Microsoft.AspNetCore.Mvc;
using SanaFirstApp.Models;
namespace SanaFirstApp.Controllers
{
    [Route("[controller]")]
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index(string name)
        {
            if (name != null)
            {
                
                return View("Views/Home/Result.cshtml", new UsernameViewModel() { UsernameView = name });

            }

            return View("Views/Home/index.cshtml");
        }
    }
}
