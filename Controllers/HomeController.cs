using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting_dojo.Models;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        private List<Dictionary<string, object>> AllUsers
        {
            get
            {
                return DbConnector.Query("SELECT * FROM users;");
            }
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(); 
        }

        [HttpPost("create")]
        public IActionResult Create(string name, string quote)
        {
            System.Console.WriteLine("hello?");

            string insert = $"INSERT INTO quotes (name, quote) VALUES ('{name}', '{quote}');";
            DbConnector.Execute(insert);
            return RedirectToAction("Quotes");
        }

        [HttpGet("result")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes ORDER BY name desc");

            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            ViewBag.Quotes = AllQuotes;
                return View("Result");
        }

        
    }
}
