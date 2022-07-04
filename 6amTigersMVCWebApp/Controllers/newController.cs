using _6amTigersMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6amTigersMVCWebApp.Controllers
{
    public class newController : Controller
    {
        // GET: new
        public string Index(int? eid)
        {
            return "HelloWorld "+ Request.QueryString["eid"] + " your name is "
                          +Request.QueryString["name"];
        }

        public string GetData()
        {
            string wish = SampleMethod();
            return wish;
        }

        public ViewResult LayoutExample()
        {
            
            return View();
        }

        [NonAction]
        public string SampleMethod()
        {
            return "Good Morning";
        }

        [Route("ipl/ViratTeam/{id:int}")]
        [Route("ipl/Rcb")]
        public string SampleMethod2(int? id)
        {
            return "Good Morning";
        }
        [Route("ipl/ViratTeam/{id:alpha}")]
        public string SampleMethod3(string id)
        {
            return "Good Morning";
        }

        public ActionResult SendData()
        {
           
            ViewBag.Name = "Shaka laka boom boom";
            return View();
        }

        public ActionResult SendData2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;

            ViewBag.det = emp;
            return View();
        }

        public ActionResult SendData3()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kavi";
            emp1.EmpSalary = 31000;


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Mavi";
            emp2.EmpSalary = 41000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            ViewBag.det = listEmp;
            return View();
        }

        public ActionResult SendData4()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;

           //object model=emp;
            return View(emp);
        }

        public ActionResult SendData5()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kavi";
            emp1.EmpSalary = 31000;


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Mavi";
            emp2.EmpSalary = 41000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


             
            return View(listEmp);
        }

        public ViewResult SendData6()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kavi";
            emp1.EmpSalary = 31000;


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Mavi";
            emp2.EmpSalary = 41000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            //Department information

            List<DepartmentModel> listdept = new List<DepartmentModel>();

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 2;
            dept2.DeptName = "EEE";

            listdept.Add(dept1);
            listdept.Add(dept2);


            EmpDept ed = new EmpDept();
            ed.emp = listEmp;
            ed.dept = listdept;



            return View(ed);
        }

        public RedirectResult GoToUrl()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GoToUrl2()
        {
            return Redirect("~/new/SendData6");
        }

        public ActionResult PartialViewExample()
        {
            return View();
        }

        public PartialViewResult PartialViewExample2()
        {
            return PartialView("_myPartialView");
        }

        public JsonResult getjsondata()
        {

            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kavi";
            emp1.EmpSalary = 31000;


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Mavi";
            emp2.EmpSalary = 41000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);
            //Department information

            List<DepartmentModel> listdept = new List<DepartmentModel>();

            DepartmentModel dept1 = new DepartmentModel();
            dept1.DeptId = 1;
            dept1.DeptName = "IT";

            DepartmentModel dept2 = new DepartmentModel();
            dept2.DeptId = 2;
            dept2.DeptName = "EEE";

            listdept.Add(dept1);
            listdept.Add(dept2);


            EmpDept ed = new EmpDept();
            ed.emp = listEmp;
            ed.dept = listdept;

            return Json(ed, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DisplayEmployeeData()
        {
            return View();
        }

        public FileResult getFileData()
        {
            return File("~/Web.config","text");
        }

        public FileResult getFileData2()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }

        public RedirectToRouteResult RedirectToActionExample()
        {
            return RedirectToAction("GoToUrl2");
        }
        public RedirectToRouteResult RedirectToActionExample2()
        {
            return RedirectToAction("Index","Default",new {id=1211});
        }
        public RedirectToRouteResult RedirectToActionExample3()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;

            return RedirectToAction("Index2", "Default", emp);
        }

        public RedirectToRouteResult RedirectToActionExample4()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Ravi";
            emp.EmpSalary = 21000;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "kavi";
            emp1.EmpSalary = 31000;


            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Mavi";
            emp2.EmpSalary = 41000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return RedirectToAction("Index3", "Default", listEmp);
        }

        public ContentResult GetContent(int id)
        {
            if (id == 1)
            {
                return Content("HelloWorld");
            }
            else if (id == 2)
            {
                return Content("<h1 style=color:red>Hello World</h1>");
            }
            else
            {
                return Content("<script>alert('welcome to World')</script>");
            }
        }

        public ActionResult ViewbagAndViewDataExample()
        {
            // ViewData["student"] = "Sanjay";
            ViewBag.student = "sandya";
            //return RedirectToAction("ViewbagAndViewDataExample2");
            return View();
        }
        public ActionResult ViewbagAndViewDataExample2()
        {
            //string value= ViewData["student"].ToString();
            string value = ViewBag.student;
            return Content(value);
        }

        public ActionResult TempdataExample()
        {
            TempData["Employee"] = "Sandya";
            return RedirectToAction("TempdataExample2");
        }

        public ActionResult TempdataExample2()
        {
            //string value = Convert.ToString(TempData["Employee"]);
            //  TempData.Keep();
            //it will initialise value and it will retain key
            string value = Convert.ToString(TempData.Peek("Employee"));
            return Content(value);
        }


        public ActionResult HtmlHelperExample()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "John";
            EmployeeEntities db = new EmployeeEntities();
            ViewBag.adgasd = new SelectList(db.employeeDetails, "EmpId", "EmpName");
            return View(emp);
        }



        public ActionResult HtmlHelperExample2(int ? id)
        {
             
            EmployeeEntities db = new EmployeeEntities();

            ViewBag.adgasd = new SelectList(db.employeeDetails, "EmpId", "EmpName");


            var   Emp = db.employeeDetails.Where(x=>x.EmpId==id).SingleOrDefault();
            return Json(Emp, JsonRequestBehavior.AllowGet);

            
        }
    }
}