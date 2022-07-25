using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorAttributeExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HandleError()]
        public ActionResult Contact2()
        {
            try
            {
                int a = 10, b = 0, c;
                c = a / b;
            }
            catch (Exception e)
            {
                if(e.Message== "Attempted to divide by zero")
                {
                    return View("Error",new HandleErrorInfo(e,"Home","Contact2"));
                }

                throw e;
            }
            return View();
        }

        public ActionResult Contact3(int d)
        {
                int a = 10, b = d, c;
                c = a / b;
            TempData["empid"] = 123;
           
                return RedirectToAction("Contact4");
        }
        public ActionResult Contact4()
        {

            //int a = (int)TempData["empid"];
            //TempData.Keep();
            int a=(int)TempData.Peek("empid");
            ViewBag.xyz = a;
            return View();
        }
    }
}