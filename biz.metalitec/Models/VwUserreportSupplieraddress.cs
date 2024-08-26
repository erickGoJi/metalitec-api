using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSupplieraddress
    {
        public int AddressId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierAddressName { get; set; }
        public string SupplierAddressLine1 { get; set; }
        public string SupplierAddressLine2 { get; set; }
        public string SupplierAddressLine3 { get; set; }
        public string SupplierAddressLine4 { get; set; }
        public string SupplierAddressPostcode { get; set; }
        public string SupplierAddressCountry { get; set; }
        public string SupplierAddressContact { get; set; }
        public string SupplierAddressTelephone { get; set; }
        public string SupplierAddressFaxNumber { get; set; }
        public string SupplierAddressMobilePhoneNumber { get; set; }
        public string SupplierAddressEMailAddress { get; set; }
    }
}
