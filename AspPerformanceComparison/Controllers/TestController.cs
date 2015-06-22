using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

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

        //GET: /Test/DoEcho
        public string DoEcho(string data)
        {
            return "Echo response: " + data + " at " + DateTime.Now;
        }
        
        //GET: /Test/DoEchoJson
        public string DoEchoJson(Dictionary<String, String> data)
        {
            return JsonConvert.SerializeObject(new
            {
                ServerMessage = "Echo response",
                ServerDateTime = DateTime.Now,
                RequestedData = data
            });
        }

        //GET: /test/DoRandomPayload
        public string DoRandomPayload(int length)
        {
            return AspPerformanceComparison.Data.RandomPayload.generate(length);
        }

        //GET: /Backend/DoRandomPerson
        public string DoRandomPerson()
        {
            return JsonConvert.SerializeObject(Persons.ARandomOne(), new Newtonsoft.Json.Converters.StringEnumConverter());
        }
    }
}