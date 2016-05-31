using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class Test4Controller : Controller
    {
        //
        // GET: /Test4/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassWord(string name, string password)
        {
            string str = "您输入的用户名：" + name + " ; 密码：" + password;
            return Content(str);
        }

    }
}
