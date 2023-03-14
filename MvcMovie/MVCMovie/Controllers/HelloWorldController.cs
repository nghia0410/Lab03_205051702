﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        // return View();
        //}
        //
        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }
        //
        // GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }


    }
}
