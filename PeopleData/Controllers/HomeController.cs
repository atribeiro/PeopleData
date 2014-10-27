using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeopleData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Employee Details Table.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This App Contains employee Confidential information.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For any additional information, please contact me at ana.ribeiro.09@gmail.com.";

            return View();
        }
    }
}
