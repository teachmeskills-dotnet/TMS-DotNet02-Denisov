using Microsoft.AspNetCore.Mvc;

namespace Denisov.TobaccoStore.Controllers
{
    public class PlacesController : Controller
    {
        public IActionResult Places()
        {
            return View();
        }
    }
}
