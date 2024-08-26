using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ApplicationForPaymentAgreedItem
    {
        public ApplicationForPaymentAgreedItem()
        {
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int ApplicationForPaymentAgreedItemId { get; set; }
        public int ApplicationForPaymentItemId { get; set; }
        public double? AppliedForValue { get; set; }
        public double? MaterialsStoredValue { get; set; }
        public double? RetentionValue { get; set; }

        public virtual ApplicationForPaymentItem ApplicationForPaymentItem { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}
