using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<string> list = new List<string>();
            list.Add("Red");
            list.Add("blue");
            list.Add("black");
            list.Add("green");
            list.Add("grey");
            list.Add("orange");

            this.ViewBag.ViewBagListColors = list;
            this.ViewData["ViewDataListColors"] = list;

            return View();
        }

    }
}
