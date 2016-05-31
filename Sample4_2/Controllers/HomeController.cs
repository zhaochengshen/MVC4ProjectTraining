using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample4_2.Models;

namespace Sample4_2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string SendHello(HelloPerson helloPerson)
        {
            return helloPerson.Name.ToString() + "，您好";
        }
        public ActionResult Hello()
        {
            return View();
        }

    }
}
