using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample5_1.Models;

namespace Sample5_1.Controllers
{
    public class Test6Controller : Controller
    {
        //
        // GET: /Test6/

        public ActionResult Index()
        {
            User user = new User();
            user.Name = "张三";
            user.Age = "21";
            user.Sex = "男";
            user.Hobby = "打球";


            return View(user);
        }
        public ActionResult UserDisplay(string name, string age, string sex, string hobby)
        {
            string str = string.Empty;
            str = "用户信息<br >";
            str += "姓名：" + name;
            str += "年龄：" + age;
            str += "性别：" + sex;
            str += "爱好：" + hobby;
            return Content(str);
        }

    }
}
