using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectJames.Models;
namespace FinalProjectJames.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MonPayment = 0;
            return View();
            
        }

        [HttpPost]
        public IActionResult Index(FinalProjectJames.Models.MontlyPayment model)
        {
            model.GetMontlyPayment();
            ViewBag.MonPayment = model.MonthlyPayment;
            return View(model);
        }
    }
}
