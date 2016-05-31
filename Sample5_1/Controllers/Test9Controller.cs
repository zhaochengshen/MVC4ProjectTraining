using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample5_1.Models;

namespace Sample5_1.Controllers
{
    public class Test9Controller : Controller
    {
        //
        // GET: /Test9/

        public ActionResult Index()
        {
            Lunch lunch = new Lunch();
            return View();
        }
        public ActionResult Display()
        {
            string str = "您选择的午餐：<br /> 水果：" + Request.Form["fruit"] + "<br />主食：" + Request.Form["food"];
            return Content(str);
        }

    }
}
