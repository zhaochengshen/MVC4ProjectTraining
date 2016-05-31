using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample5_1.Models;

namespace Sample5_1.Controllers
{
    public class Test11Controller : Controller
    {
        //
        // GET: /Test11/

        public ActionResult Index()
        {
            Message message = new Message();
            message.Content = "这是TextArea帮助器的使用";
            return View(message);
        }
        public ActionResult TextAreaFor()
        {
            string str = "您输入的信息是：" + Request.Form["content"].ToString();
            return Content(str);
        }


    }
}
