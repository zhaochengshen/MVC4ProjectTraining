using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample5_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckBox(FormCollection formCollection)
        {
            string str = "你选中的颜色为:";
            var select = from x in formCollection.AllKeys where formCollection[x].Contains("true") select x;



            foreach (var item in select)
            {
                if (item == "Red")
                {
                    str += "红色";
                }
                if (item == "Blue")
                {
                    str += "蓝色";
                }
                if (item == "Green")
                {
                    str += "绿色";
                }
            }

            return Content(str + ";;;;" + Request.Form["txt"].ToString());

        }
    }
}
