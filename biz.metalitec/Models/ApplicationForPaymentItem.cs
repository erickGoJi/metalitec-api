using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ApplicationForPaymentItem
    {
        public ApplicationForPaymentItem()
        {
            ApplicationForPaymentAgreedItems = new HashSet<ApplicationForPaymentAgreedItem>();
        }

        public int ApplicationForPaymentItemId { get; set; }
        public int ApplicationForPaymentId { get; set; }
        public int? ContractInvoiceScheduleId { get; set; }
        public double? AppliedForValue { get; set; }
        public double? MaterialsStoredValue { get; set; }
        public double? RetentionValue { get; set; }
        public int? ChangeOrderId { get; set; }

        public virtual ApplicationForPayment ApplicationForPayment { get; set; }
        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual ContractInvoiceSchedule ContractInvoiceSchedule { get; set; }
        public virtual ICollection<ApplicationForPaymentAgreedItem> ApplicationForPaymentAgreedItems { get; set; }
    }
}
