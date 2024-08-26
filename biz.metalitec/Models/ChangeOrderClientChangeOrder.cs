using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderClientChangeOrder
    {
        public ChangeOrderClientChangeOrder()
        {
            ChangeOrderClientDocumentLinks = new HashSet<ChangeOrderClientDocumentLink>();
            ChangeOrderLinks = new HashSet<ChangeOrderLink>();
        }

        public int ChangeOrderClientChangeOrderId { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public DateTime? DateReceived { get; set; }
        public byte? Status { get; set; }
        public DateTime? DateApproved { get; set; }
        public string Notes { get; set; }
        public int? ContractId { get; set; }
        public double InvoicedCompletion { get; set; }
        public double InvoicedRetention { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ChangeOrderClientDocumentLink> ChangeOrderClientDocumentLinks { get; set; }
        public virtual ICollection<ChangeOrderLink> ChangeOrderLinks { get; set; }
    }
}
