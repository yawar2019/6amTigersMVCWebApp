using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _6amTigersMVCWebApp.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public bool Status { get; set; }
    }
}