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

                //if (reader.IsColumnExists("EmailId"))
                //    item.Employee_LastName = SqlHelper.GetNullableString(reader, "EmailId");

                //if (reader.IsColumnExists("Address"))
                //    item.Address = SqlHelper.GetNullableString(reader, "Address");

                //if (reader.IsColumnExists("Mobile"))
                //    item.Mobile = SqlHelper.GetNullableString(reader, "Mobile");

                //if (reader.IsColumnExists("IsActive"))
                //    item.IsActive = SqlHelper.GetBoolean(reader, "IsActive");

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
        }
    
}
