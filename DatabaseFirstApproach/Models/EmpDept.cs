using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseFirstApproach.Models
{
    public class EmpDept
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int? EmpSalary { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}