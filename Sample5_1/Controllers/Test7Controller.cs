using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test7Controller : Controller
    {
        //
        // GET: /Test7/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DropDownList(string fruit)
        {
            string str = "您选择的水果是：" + fruit;
            return Content(str);
        }

    }
}
