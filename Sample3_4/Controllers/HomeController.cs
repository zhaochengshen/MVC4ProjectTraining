using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            TempData["TempData"] = "使用TempData进行跨行为方法传值！";
            Response.Redirect("About");
            return View();
        }
        public ActionResult About()
        { 
            return View();
        }

    }
}
