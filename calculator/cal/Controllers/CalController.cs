using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cal.Controllers
{
    public class CalController : Controller
    {
        // GET: Cal
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Total(int value1, int value2,string cal)
        {
            int total = 0;
            switch (cal)
            {
                case "+":
                    total = value1 + value2;
                    break;
                case "-":
                    total = value1 - value2;
                    break;

                case "*":
                    total = value1 * value2;
                    break;

                case "/":
                    total = value1 / value2;
                    break;
                default:
                    total = 0;
                    break;

            }
            return Content( "result :" +total);

        }
    }
}