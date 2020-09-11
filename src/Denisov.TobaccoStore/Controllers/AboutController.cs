using Microsoft.AspNetCore.Mvc;

namespace Denisov.TobaccoStore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
