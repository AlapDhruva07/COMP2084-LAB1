using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP2084_LAB1.Models;

namespace COMP2084_LAB1.Controllers
{
    public class HomeController : Controller
    {
        int num1, num2;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Addition(int a,int b)
        {
            
            return Ok(a.ToString() + "+" + b.ToString()+ "="+ (a+b).ToString());
        }

        public IActionResult Multiplication(int a, int b)
        {

            return Ok(a.ToString() + "*" + b.ToString() + "=" + (a * b).ToString());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
