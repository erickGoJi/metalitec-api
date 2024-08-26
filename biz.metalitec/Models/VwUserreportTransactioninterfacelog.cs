using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportTransactioninterfacelog
    {
        public int TransactionInterfaceLogId { get; set; }
        public string TransactionInterfaceLog { get; set; }
        public string TransactionInterface { get; set; }
        public string TransactionInterfaceDescription { get; set; }
        public string LogType { get; set; }
        public string LogDetails { get; set; }
    }
}
