using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwTransactioninterfacelogSearch
    {
        public int TransactionInterfaceLogId { get; set; }
        public string Name { get; set; }
        public string InterfaceName { get; set; }
        public string InterfaceDescription { get; set; }
        public string TransactionInterfaceType { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
