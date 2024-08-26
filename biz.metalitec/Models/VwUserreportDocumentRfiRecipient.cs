﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportDocumentRfiRecipient
    {
        public int DocumentTransmittalRecipientId { get; set; }
        public int DocumentTransmittalId { get; set; }
        public string DocumentRfi { get; set; }
        public string ContactName { get; set; }
        public string CompanyType { get; set; }
        public string Company { get; set; }
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
        public string DefaultEMailPriority { get; set; }
        public double? DefaultMaxEMailSizeKb { get; set; }
        public byte? TeamLeader { get; set; }
    }
}
