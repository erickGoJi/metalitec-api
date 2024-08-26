using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ApplicationForPayment
    {
        public ApplicationForPayment()
        {
            ApplicationForPaymentCorrespondences = new HashSet<ApplicationForPaymentCorrespondence>();
            ApplicationForPaymentItems = new HashSet<ApplicationForPaymentItem>();
            SalesInvoices = new HashSet<SalesInvoice>();
        }

        public int ApplicationForPaymentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public int ContractId { get; set; }
        public int ApplicationNumber { get; set; }
        /// <summary>
        /// Date of Application
        /// </summary>
        public DateTime ApplicationDate { get; set; }
        /// <summary>
        /// Date Application due for Submission
        /// </summary>
        public DateTime? ApplicationDueDate { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        public int? CurrencyId { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ApplicationForPaymentCorrespondence> ApplicationForPaymentCorrespondences { get; set; }
        public virtual ICollection<ApplicationForPaymentItem> ApplicationForPaymentItems { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}
