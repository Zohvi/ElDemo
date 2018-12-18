using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testi13._12.Models;

namespace testi13._12.Controllers
{
    public class OmistajatController : Controller
    {
        public IActionResult Index()
        {
            EläimiäContext context = new EläimiäContext();
            List<Omistajat> omistaja = context.Omistajat.ToList();
            return View(omistaja);
        }
        public IActionResult UusiOmistaja()
        {
            return View();
        
        }
        [HttpPost]
        public IActionResult UusiOmistaja(Omistajat uusi)
        {
            EläimiäContext context = new EläimiäContext();
            context.Omistajat.Add(uusi);
            context.SaveChanges();
            return View();

        }

    }
}