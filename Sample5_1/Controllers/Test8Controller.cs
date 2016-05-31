using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample5_1.Models;

namespace Sample5_1.Controllers
{
    public class Test8Controller : Controller
    {
        //
        // GET: /Test8/

        public ActionResult Index()
        {
            User user = new User();
            user.Name = "张三";
            user.Age = "21";
            user.Sex = "男";
            user.Hobby = "爱好";

            return View(user);
        }

        public ActionResult UserDisplay()
        {
            string str = "您选择的性别是：" + Request.Form["sex"].ToString();
            return Content(str);
        }
    }
}
