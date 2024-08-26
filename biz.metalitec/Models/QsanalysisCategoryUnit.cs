using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QsanalysisCategoryUnit
    {
        public int QsanalysisCategoryUnitId { get; set; }
        public int QsanalysisCategoryId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// The Cost Price Unit
        /// </summary>
        public int CostUnitId { get; set; }
        public double CostUnitQuantity { get; set; }
        /// <summary>
        /// The Cost Unit Price
        /// </summary>
        public double CostUnitPrice { get; set; }
        /// <summary>
        /// Calculated Using the Category Unit and Unit Price
        /// </summary>
        public double CostValue { get; set; }
        /// <summary>
        /// Sell Unit ID
        /// </summary>
        public int SellUnitId { get; set; }
        public double SellUnitQuantity { get; set; }
        /// <summary>
        /// The Sell Unit Price
        /// </summary>
        public double SellUnitPrice { get; set; }
        /// <summary>
        /// Calculated Sell Value for the Category
        /// </summary>
        public double SellValue { get; set; }
        public int Sort { get; set; }
        /// <summary>
        /// The Contract Milestone ID of the QS Analysis Category
        /// </summary>
        public int? ContractInvoiceScheduleId { get; set; }

        public virtual ContractInvoiceSchedule ContractInvoiceSchedule { get; set; }
        public virtual QsanalysisCategory QsanalysisCategory { get; set; }
    }
}
