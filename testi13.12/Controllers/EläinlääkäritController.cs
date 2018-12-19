using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testi13._12.Models;

namespace testi13._12.Controllers
{
    public class EläinlääkäritController : Controller
    {
        public IActionResult Index()
        {
            EläimiäContext context = new EläimiäContext();
            List<Eläinlääkärit> eläinlääkäri = context.Eläinlääkärit.ToList();
            return View(eläinlääkäri);
        }
        public IActionResult UusiEläinlääkäri()
        {
            return View();

        }
        [HttpPost]
        public IActionResult UusiEläinlääkäri(Eläinlääkärit uusi)
        {
            EläimiäContext context = new EläimiäContext();
            context.Eläinlääkärit.Add(uusi);
            context.SaveChanges();
            return View();

        }

    }


}