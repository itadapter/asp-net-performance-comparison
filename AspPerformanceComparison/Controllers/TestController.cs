using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AspPerformanceComparison.Data;

namespace AspPerformanceComparison.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: /Test/Echo
        public ActionResult Echo()
        {
            return View();
        }

        // GET: /Test/EchoJson
        public ActionResult EchoJson()
        {
            return View();
        }

        // GET: /Test/RandomPerson
        public ActionResult RandomPerson()
        {
            return View(Persons.ARandomOne());
        }

        // GET: /Test/RandomPersonSimple
        public ActionResult RandomPersonSimple()
        {
            return View(Persons.ARandomOne());
        }


    }
}