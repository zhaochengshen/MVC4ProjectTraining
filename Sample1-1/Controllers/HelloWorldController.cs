using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample1_1.Models;

namespace Sample1_1.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/



        public string SendHello(HelloPerson helloPerson)
        {
            return helloPerson.Name.ToString() + helloPerson.Say.ToString();
        }
         

        public ActionResult Hello()
        {
            return View();
        }

    }
}
