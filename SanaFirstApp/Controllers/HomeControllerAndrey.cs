using Microsoft.AspNetCore.Mvc;
using SanaFirstApp.Models;
namespace SanaFirstApp.Controllers
{
    [Route("[controller]")]
    [Route("")]
    public class HomeControllerAndrey : Controller
    {
        public IActionResult Index(string name)
        {
            if (name != null)
            {
                
                return View("Views/EmoH/Result.cshtml", new UsenameViewModel() { UsenameView = name });

            }

            return View("Views/EmoH/index.cshtml");
        }
    }
}
