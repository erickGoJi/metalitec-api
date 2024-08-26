using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractInvoiceSchedule
    {
        public ContractInvoiceSchedule()
        {
            ApplicationForPaymentItems = new HashSet<ApplicationForPaymentItem>();
            QsanalysisCategoryUnits = new HashSet<QsanalysisCategoryUnit>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
        }

        public int ContractInvoiceScheduleId { get; set; }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public DateTime? ExpectedInvoiceDate { get; set; }
        public double ExpectedInvoiceValue { get; set; }
        public int CostCodeId { get; set; }
        public double ActualInvoiceValue { get; set; }
        public double InvoicedCompletion { get; set; }
        public double InvoicedMaterialsStored { get; set; }
        public double InvoicedRetention { get; set; }
        public int ItemNo { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ApplicationForPaymentItem> ApplicationForPaymentItems { get; set; }
        public virtual ICollection<QsanalysisCategoryUnit> QsanalysisCategoryUnits { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
