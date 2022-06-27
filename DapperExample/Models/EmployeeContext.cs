using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
namespace DapperExample.Models
{
    public class EmployeeContext
    {
        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");
        public List<EmployeeModel> getEmployees()
        {
            var result = con.Query<EmployeeModel>("sp_employee", commandType: System.Data.CommandType.StoredProcedure).ToList();
            return result;
        }

        public int SaveEmployee(EmployeeModel emp)
        {
            var param = new DynamicParameters();

            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);


            var result = con.Execute("sp_CreateEmployee",param:param, commandType: System.Data.CommandType.StoredProcedure);
            return result;
        }
    }
}