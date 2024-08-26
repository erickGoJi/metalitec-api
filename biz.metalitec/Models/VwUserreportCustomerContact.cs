using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportCustomerContact
    {
        public int ContactId { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string Contact { get; set; }
        public string ContactTitle { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactJobTitle { get; set; }
        public string CompanyNumber { get; set; }
        public string ContactAddressLine1 { get; set; }
        public string ContactAddressLine2 { get; set; }
        public string ContactAddressLine3 { get; set; }
        public string ContactAddressLine4 { get; set; }
        public string ContactAddressPostCode { get; set; }
        public string ContactAddressCountry { get; set; }
        public string ContactHomePhoneNumber { get; set; }
        public string ContactMobilePhoneNumber { get; set; }
        public string ContactFaxNumber { get; set; }
        public string ContactEMailAddress1 { get; set; }
        public string ContactEMailAddress2 { get; set; }
        public string ContactNotes { get; set; }
        public bool DocumentManagementContact { get; set; }
        public int? DefaultResponseDays { get; set; }
        public bool? DefaultAcknowledgement { get; set; }
        public int? DocumentTransmittalReasonId { get; set; }
        public string DefaultReason { get; set; }
        public int? DefaultCopies { get; set; }
        public string DefaultEMailPriority { get; set; }
        public double? DefaultMaxEMailSizeKb { get; set; }
    }
}
