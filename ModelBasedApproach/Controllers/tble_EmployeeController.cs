using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelBasedApproach.Models;

namespace ModelBasedApproach.Controllers
{
    public class tble_EmployeeController : Controller
    {
        private ModelBasedApproachContext db = new ModelBasedApproachContext();

        // GET: tble_Employee
        public ActionResult Index()
        {
            return View(db.tble_Employee.ToList());
        }

        // GET: tble_Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Employee tble_Employee = db.tble_Employee.Find(id);
            if (tble_Employee == null)
            {
                return HttpNotFound();
            }
            return View(tble_Employee);
        }

        // GET: tble_Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tble_Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Salary")] tble_Employee tble_Employee)
        {
            if (ModelState.IsValid)
            {
                db.tble_Employee.Add(tble_Employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tble_Employee);
        }

        // GET: tble_Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Employee tble_Employee = db.tble_Employee.Find(id);
            if (tble_Employee == null)
            {
                return HttpNotFound();
            }
            return View(tble_Employee);
        }

        // POST: tble_Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Salary")] tble_Employee tble_Employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tble_Employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tble_Employee);
        }

        // GET: tble_Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tble_Employee tble_Employee = db.tble_Employee.Find(id);
            if (tble_Employee == null)
            {
                return HttpNotFound();
            }
            return View(tble_Employee);
        }

        // POST: tble_Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tble_Employee tble_Employee = db.tble_Employee.Find(id);
            db.tble_Employee.Remove(tble_Employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
