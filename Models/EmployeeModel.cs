using System.Runtime.Serialization;

namespace ngWithJwt.Models
{
    [DataContract]
    public class EmployeeModel
    {
        [DataMember(Name = "Id")]
        public int Employee_Id { get; set; }

        public string Employee_FirstName { get; set; }
        public string Employee_MiddleName { get; set; }
        public string Employee_LastName { get; set; }
        public string Employee_Designation { get; set; }
        public string Employee_ReportingTo { get; set; }
        public string Employee_CreatedBy { get; set; }
        public string Employee_CreatedOn { get; set; }
        public string Employee_ModifiedBy { get; set; }
        public string Employee_ModifiedOn { get; set; }
        public string Designation_Description { get; set; }
        public string Salary_Amount { get; set; }
    }
}
