using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class employeeDetailsApiController : ApiController
    {
        private EmployeeEntities db = new EmployeeEntities();

        // GET: api/employeeDetailsApi
        public IQueryable<employeeDetail> GetemployeeDetails()
        {
            return db.employeeDetails;
        }

        // GET: api/employeeDetailsApi/5
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult GetemployeeDetail(int id)
        {
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            return Ok(employeeDetail);
        }

        // PUT: api/employeeDetailsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutemployeeDetail(int id, employeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employeeDetail.EmpId)
            {
                return BadRequest();
            }

            db.Entry(employeeDetail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employeeDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/employeeDetailsApi
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult PostemployeeDetail(employeeDetail employeeDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employeeDetails.Add(employeeDetail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employeeDetail.EmpId }, employeeDetail);
        }

        // DELETE: api/employeeDetailsApi/5
        [ResponseType(typeof(employeeDetail))]
        public IHttpActionResult DeleteemployeeDetail(int id)
        {
            employeeDetail employeeDetail = db.employeeDetails.Find(id);
            if (employeeDetail == null)
            {
                return NotFound();
            }

            db.employeeDetails.Remove(employeeDetail);
            db.SaveChanges();

            return Ok(employeeDetail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool employeeDetailExists(int id)
        {
            return db.employeeDetails.Count(e => e.EmpId == id) > 0;
        }
    }
}