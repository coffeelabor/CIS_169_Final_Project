using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectJames.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.loanAmount = 15000;
            ViewBag.interestRate = .03;
            ViewBag.yearsOfLoan = 15;
            ViewBag.monthlyPayment = 1000.33;
            return View();
        }
    }
}
