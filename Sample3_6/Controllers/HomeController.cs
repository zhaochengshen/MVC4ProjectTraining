using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample3_6.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //返回ContentResult
        public ContentResult TestContentResult(bool result, string msg)
        {
            string contentType = "text/plain";
            if (result == false)
            {
                contentType = "text/html";
            }

            return Content(Server.HtmlEncode(Server.HtmlEncode(msg)), contentType, System.Text.Encoding.UTF8);
        }

        ////返回jsonResult
        //[AcceptVerbs(HttpVerbs.Post)]
        //public JsonResult TestJsonContentEnc()
        //{
        //    int numDays = 5;
        //    return Json(GetDataRangeStr(DateTime.Now, DateTime.Now.AddDays(numDays)), "text/x-json", System.Text.Encoding.UTF8);
        //}
        //public IEnumerable<string> GetDataRangeStr(DateTime start, DateTime endD)
        //{
        //    while (start <= endD)
        //    {
        //        yield return start.ToShortDateString();
        //        start = start.AddDays(1);
        //    }
        //}


        ////返回javaScriptResult
        //public JavaScriptResult TestjavaScript()
        //{
        //    string s = "$('#DIVrESULTtEXT').HTML('JavaScript测试！')";
        //    return JavaScript(s);
        //}

        ////返回fileResult
        //public FileResult ShowFileFN(string id)
        //{
        //    string mp = Server.MapPath("~/Content/" + id);//文件地址
        //    return File(mp, "text/html");
        //}


    }
}
