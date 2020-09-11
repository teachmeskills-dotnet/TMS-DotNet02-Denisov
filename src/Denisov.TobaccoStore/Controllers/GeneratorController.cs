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
        private DenisovDbContext db;

        public GeneratorController(DenisovDbContext context)
        {
            db = context;
        }

        public IActionResult Generator()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> TobaccoGeneratorResult()
        {
            var tobaccos = await db.Tobaccos.ToListAsync();
            var random = new Random();
            int index = random.Next(tobaccos.Count);
            return View(tobaccos[index]);
        }

        [Authorize]
        public async Task<IActionResult> MixGeneratorResult()
        {
            var mixes = await db.Mixes.ToListAsync();
            var random = new Random();
            int index = random.Next(mixes.Count);
            return View(mixes[index]);
        }
    }
}