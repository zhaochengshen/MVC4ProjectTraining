using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //定义一个列表
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem { Text = "张三", Value = "1" });
            list.Add(new SelectListItem { Text = "王五", Value = "2", Selected = true });
            list.Add(new SelectListItem { Text = "Tom", Value = "3" });

            this.ViewData["ViewDataList"] = list;
            this.ViewBag.ViewBagList = list;
            return View();
        }

    }
}
