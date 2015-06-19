using AspPerformanceComparison.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspPerformanceComparison.Controllers
{
    public class BackendController : Controller
    {
        //GET: /Backend/Echo
        public string Echo(string data)
        {
            return "Echo response: " + data + " at " + DateTime.Now;
        }
        
        //GET: /Backend/EchoJson
        public string EchoJson(Dictionary<String, String> data)
        {
            return JsonConvert.SerializeObject(new
            {
                ServerMessage = "Echo response",
                ServerDateTime = DateTime.Now,
                RequestedData = data
            });
        }

        //GET: /Backend/RandomPayload
        public string RandomPayload(int length)
        {
            return AspPerformanceComparison.Data.RandomPayload.generate(length);
        }

        //GET: /Backend/RandomPerson
        public string RandomPerson()
        {
            return JsonConvert.SerializeObject(Persons.ARandomOne(), new Newtonsoft.Json.Converters.StringEnumConverter());
        }
    }
}