using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test5Controller : Controller
    {
        //
        // GET: /Test5/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hidden(string name, string password, string hidden)
        {
            string str = "你输入的用户名：" + name + " ; 密码：" + password + " ;<br />隐藏信息是：" + hidden;
            return Content(str);
        }

    }
}
