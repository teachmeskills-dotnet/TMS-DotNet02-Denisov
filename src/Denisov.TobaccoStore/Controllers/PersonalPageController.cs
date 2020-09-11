using Microsoft.AspNetCore.Mvc;

namespace Denisov.TobaccoStore.Controllers
{
    public class PersonalPageController : Controller
    {
        public IActionResult PersonalPage()
        {
            return View();
        }
    }
}
