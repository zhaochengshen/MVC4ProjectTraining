using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test10Controller : Controller
    {
        //
        // GET: /Test10/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TextArea()
        {
            string str = "你输入的是：" + Request.Form["message"].ToString();
            return Content(str);
        }

    }
}
