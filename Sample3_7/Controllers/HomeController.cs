using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Sample3_7.Controllers
{
    public class HomeController : AsyncController
    {
        //
        // GET: /Home/ 

        public void IndexAsync()
        {
            //获取文件地址
            string address = Server.MapPath("AsyncController.txt");
            //实现异步action 加1
            AsyncManager.OutstandingOperations.Increment();
            //创建文件流
            FileStream filestream = new FileStream(address, FileMode.Open);
            byte[] byteArray = new byte[filestream.Length];
            filestream.BeginRead(byteArray, 0, (int)filestream.Length, (IAsyncResult result) =>
            {
                //定义字节编码，汉子在处理过程中需要定义相应的编码才能正常显示
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                string content = encoding.GetString(byteArray);
                //参数要放在这个字典里面实现Completed action传递
                AsyncManager.Parameters["content"] = content;
                //异步action回调
                AsyncManager.OutstandingOperations.Decrement();
                filestream.Close();
            }, null);
        }
        //这个action 以Completed 为后缀异步action结束后调用的函数，返回ActionResult
        public ActionResult IndexCompleted(string content)
        {
            Response.Write(content);
            return View();
        }
    }
}
