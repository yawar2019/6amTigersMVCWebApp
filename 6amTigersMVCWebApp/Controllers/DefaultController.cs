using _6amTigersMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6amTigersMVCWebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(int? id)
        {
            ViewBag.EmpId = id;
            return View();
        }

        public ActionResult Index2(EmployeeModel emp)
        {
            
            return View();
        }

        public ActionResult Index3(List<EmployeeModel> listEmp)
        {

            return View();
        }

    }
}