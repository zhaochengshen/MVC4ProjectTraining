using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test3Controller : Controller
    {
        //
        // GET: /Test3/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TextBox(string name, string age)
        {
            string str = "您输入的名字是：" + name + "; 年龄：" + age;
            return Content(str);
        }

    }
}
