using System.Collections.Generic;
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
    }
}
