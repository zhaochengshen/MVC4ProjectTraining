
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_5.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public void Index(string userName, string passWord)
        {
            if (userName == "zhang" && passWord == "password")
            {
                Response.Write("登录成功！用户名：" + userName + "密码：" + passWord);
            }
            else
            {
                Response.Write("登录失败！");
            }
        }

    }
}
