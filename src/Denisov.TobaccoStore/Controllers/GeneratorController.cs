using Denisov.Common.Interfaces;
using Denisov.DAL;
using Denisov.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
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
        //public IActionResult GeneratorResult()
        //{
        //    return View(db.Tobaccos);
        //}

        public IActionResult GeneratorResult(IServiceCollection services)
        {
            //var tobaccos = await db.Tobaccos.ToListAsync();
            //var random = new Random();
            //int index = random.Next(tobaccos.Count);
            return View(services);
        }


        public IActionResult Generator()
        {
            return View();
        }

    }
}