using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample4_1.Models;

namespace Sample4_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            Student stu = new Student();
            stu.Name = "张三";
            stu.Age = "21";

            return View(stu);
        }

    }
}
