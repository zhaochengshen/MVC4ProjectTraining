using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            string str = "测试Request Response Server Session 对象<br/>"; 
            //获取服务器名称
            str += "使用Server获取服务器名称：" + Server.MachineName.ToString() + " <br>";
            //使用Request对象获取URL
            str += "使用Request获取URL地址：" + Request.Url.ToString() + "<br>";
            //定义一个Session对象
            Session["MVC"] = "MVC中Session对象";
            //获取Session对象
            str += " Session:" + Session["MVC"].ToString(); 
            Response.Write(str); 
            return View();
        }

    }
}
