using System.Collections.Generic;
using System.Data.SqlClient;
using ngWithJwt.Models;
using ngWithJwt.Translator;
using ngWithJwt.Utility;

namespace ngWithJwt.Repository
{
    public class EmployeeDbClient
    {
        public List<EmployeeModel> GetAllEmployee(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<EmployeeModel>>(connString,
                "GetEmployee", r => r.TranslateAsEmployeeList());
        }

        public EmployeeModel GetEmployeeById(string connString,int Id)
        {
            SqlParameter[] param = {
                new SqlParameter("@Id",Id)               
            };
            return SqlHelper.ExtecuteProcedureReturnData<EmployeeModel>(connString,
                "GetEmployeeById", r => r.TranslateAsEmployee(),param);
        }
        public List<EmployeeModel> GetDesignationwiseSalary(string connString)
        {
            return SqlHelper.ExtecuteProcedureReturnData<List<EmployeeModel>>(connString,
                "GetDesignationwiseSalary", r => r.TranslateAsDesignationSalaryList());
        }
    }
}
