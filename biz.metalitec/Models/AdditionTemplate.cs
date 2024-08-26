using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class AdditionTemplate
    {
        public AdditionTemplate()
        {
            Additions = new HashSet<Addition>();
        }

        public int AdditionTemplateId { get; set; }
        /// <summary>
        /// Specify a name for the addition.
        /// </summary>
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        /// <summary>
        /// Specify a unit price for the addition.
        /// </summary>
        public double? UnitPrice { get; set; }
        public bool WillAddToInventoryValue { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        /// <summary>
        /// Specify a unit for the addition.
        /// </summary>
        public int? UnitId { get; set; }
        /// <summary>
        /// Specify a supplier for the addition.
        /// </summary>
        public int? SupplierId { get; set; }
        public int? AddressId { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? TaxCodeId { get; set; }
        public int? CostCodeId { get; set; }
        public int? CurrencyId { get; set; }
        public int FacilityId { get; set; }

        public virtual Address Address { get; set; }
        public virtual CostCode CostCode { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
    }
}
