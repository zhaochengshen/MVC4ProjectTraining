using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test2Controller : Controller
    {
        //
        // GET: /Test2/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RadioButton(string color)
        {
            string str = "您选择的颜色是：" + color;
            return Content(str);
        }
    }
}
