using ngWithJwt.Utility;
using ngWithJwt.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ngWithJwt.Translator
{  
    public static class EmployeeTranslator
        {
            public static EmployeeModel TranslateAsEmployee(this SqlDataReader reader, bool isList = false)
            {
                if (!isList)
                {
                    if (!reader.HasRows)
                        return null;
                    reader.Read();
                }
                var item = new EmployeeModel();
                if (reader.IsColumnExists("Employee_Id"))
                    item.Employee_Id = SqlHelper.GetNullableInt32(reader, "Employee_Id");

                if (reader.IsColumnExists("Employee_FirstName"))
                    item.Employee_FirstName = SqlHelper.GetNullableString(reader, "Employee_FirstName");

            if (reader.IsColumnExists("Employee_LastName"))
                item.Employee_LastName = SqlHelper.GetNullableString(reader, "Employee_LastName");

            if (reader.IsColumnExists("Designation_Description"))
                item.Designation_Description = SqlHelper.GetNullableString(reader, "Designation_Description");

            if (reader.IsColumnExists("Salary_Amount"))
                item.Salary_Amount = SqlHelper.GetNullableString(reader, "Salary_Amount");

            if (reader.IsColumnExists("employee_ReportingTo"))
                item.Employee_ReportingTo = SqlHelper.GetNullableString(reader, "employee_ReportingTo");

            //if (reader.IsColumnExists("Employee_IsActive"))
            //    item.Employee_IsActive = SqlHelper.GetBoolean(reader, "Employee_IsActive");

            return item;
            }

            public static List<EmployeeModel> TranslateAsEmployeeList(this SqlDataReader reader)
            {
                var list = new List<EmployeeModel>();
                while (reader.Read())
                {
                    list.Add(TranslateAsEmployee(reader, true));
                }
                return list;
            }

        public static EmployeeModel TranslateAsDesignationSalary(this SqlDataReader reader, bool isList = false)
        {
            if (!isList)
            {
                if (!reader.HasRows)
                    return null;
                reader.Read();
            }
            var item = new EmployeeModel();
          
            if (reader.IsColumnExists("Salary_Amount"))
                item.Salary_Amount = SqlHelper.GetNullableString(reader, "Salary_Amount");

            
            return item;
        }
        public static List<EmployeeModel> TranslateAsDesignationSalaryList(this SqlDataReader reader)
        {
            var list = new List<EmployeeModel>();
            while (reader.Read())
            {
                list.Add(TranslateAsDesignationSalary(reader, true));
            }
            return list;
        }
    }
    
}
