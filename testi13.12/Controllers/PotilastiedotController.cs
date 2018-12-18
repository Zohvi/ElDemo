using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testi13._12.Models;

namespace testi13._12.Controllers
{
    public class PotilastiedotController : Controller
    {
        public IActionResult Index()
        {
            EläimiäContext context = new EläimiäContext();
            List<Potilastiedot> potilastiedot = context.Potilastiedot.ToList();
            return View(potilastiedot);
        }
        public IActionResult UusiPotilastieto()
        {
            return View();

        }
        [HttpPost]
        public IActionResult UusiPotilastieto(Potilastiedot uusi)
        {
            EläimiäContext context = new EläimiäContext();
            context.Potilastiedot.Add(uusi);
            context.SaveChanges();
            return View();

        }

    }

   
}