using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Edifile
    {
        public Edifile()
        {
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ContractPrelimMarkSequences = new HashSet<ContractPrelimMarkSequence>();
            EdifileContracts = new HashSet<EdifileContract>();
        }

        public int EdifileId { get; set; }
        public int? SupplierId { get; set; }
        public int? CustomerId { get; set; }
        public byte ListingTypeId { get; set; }
        public string EdibatchNo { get; set; }
        public int FileNo { get; set; }
        public string Email { get; set; }
        public int? NestingResultId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public int? SalesOrderId { get; set; }
        public string SentXml { get; set; }
        public string ReceivedXml { get; set; }
        public DateTime? DateSent { get; set; }
        public string SentBy { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string CancelledBy { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string ProcessedBy { get; set; }
        public int? ContractId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual NestingResult NestingResult { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ContractPrelimMarkSequence> ContractPrelimMarkSequences { get; set; }
        public virtual ICollection<EdifileContract> EdifileContracts { get; set; }
    }
}
