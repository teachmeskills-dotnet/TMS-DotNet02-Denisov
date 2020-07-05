using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
