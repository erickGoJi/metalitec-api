using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEmployee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public int? EmployeePosition { get; set; }
        public string EmployeeAddressLine1 { get; set; }
        public string EmployeeAddressLine2 { get; set; }
        public string EmployeeAddressLine3 { get; set; }
        public string EmployeeAddressLine4 { get; set; }
        public string EmployeeAddressPostCode { get; set; }
        public string EmployeeAddressCountry { get; set; }
        public string EmployeeContact { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeTelephone { get; set; }
        public string EmployeeFaxNumber { get; set; }
        public string EmployeeMobilePhoneNumber { get; set; }
        public string EmployeeEMailAddress { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public byte Active { get; set; }
    }
}
