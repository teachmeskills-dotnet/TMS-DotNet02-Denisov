using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
