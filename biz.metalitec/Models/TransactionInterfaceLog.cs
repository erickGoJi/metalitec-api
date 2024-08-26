using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TransactionInterfaceLog
    {
        public int TransactionInterfaceLogId { get; set; }
        /// <summary>
        /// The Name of the Transaction Interface Log
        /// </summary>
        public string Name { get; set; }
        public int TransactionInterfaceId { get; set; }
        /// <summary>
        /// Whether the Transaction Interface record processed was successful, failed or for information
        /// </summary>
        public int LogTypeId { get; set; }
        /// <summary>
        /// Details of the Transaction Interface record processed
        /// </summary>
        public string LogDetails { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public virtual TransactionInterface TransactionInterface { get; set; }
    }
}
