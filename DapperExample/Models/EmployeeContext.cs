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
            string spName=string.Empty;
            var param = new DynamicParameters();

            param.Add("@EmpName", emp.EmpName);
            param.Add("@EmpSalary", emp.EmpSalary);

            if (emp.EmpId > 0)
            {
                param.Add("@EmpId", emp.EmpId);
                spName = "spr_updateEmployeeDetails";
            }
            else
            {
                spName = "sp_CreateEmployee";

            }

            var result = con.Execute(spName, param: param, commandType: System.Data.CommandType.StoredProcedure);
           
            return result;
        }

        public EmployeeModel getEmployeesById(int? id)
        {
            var param = new DynamicParameters();

            param.Add("@EmpId", id);
             
            EmployeeModel emp = con.QuerySingle<EmployeeModel>("sp_getNeerjaEmployeeDetailsById", param: param, commandType: System.Data.CommandType.StoredProcedure);

            return emp;
        }

        public int deleteEmployeeById(int? id)
        {
            var param = new DynamicParameters();

            param.Add("@empid", id);

            var result = con.Execute("spr_deleteEmployeeDetails", param: param, commandType: System.Data.CommandType.StoredProcedure);

            return result;

        }
    }
}