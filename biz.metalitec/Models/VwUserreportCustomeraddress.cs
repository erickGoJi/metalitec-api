using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportCustomeraddress
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerAddressName { get; set; }
        public string CustomerAddressLine1 { get; set; }
        public string CustomerAddressLine2 { get; set; }
        public string CustomerAddressLine3 { get; set; }
        public string CustomerAddressLine4 { get; set; }
        public string CustomerAddressPostcode { get; set; }
        public string CustomerAddressCountry { get; set; }
        public string CustomerAddressContact { get; set; }
        public string CustomerAddressTelephone { get; set; }
        public string CustomerAddressFaxNumber { get; set; }
        public string CustomerAddressMobilePhoneNumber { get; set; }
        public string CustomerAddressEMailAddress { get; set; }
    }
}
