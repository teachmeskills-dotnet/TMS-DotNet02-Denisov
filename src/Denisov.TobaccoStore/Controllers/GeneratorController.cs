using Denisov.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Denisov.TobaccoStore.Controllers
{
    public class GeneratorController : Controller
    {
        DenisovDbContext db;

        public GeneratorController(DenisovDbContext context)
        {
            db = context;
        }
        [Authorize]
        public async Task<IActionResult> GeneratorResult()
        {
            var tobaccos = await db.Tobaccos.ToListAsync();
            var random = new Random();
            int index = random.Next(tobaccos.Count);
            return View(tobaccos[index]);
        }


        public IActionResult Generator()
        {
            return View();
        }

    }
}