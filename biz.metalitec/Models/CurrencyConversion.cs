using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class CurrencyConversion
    {
        /// <summary>
        /// Unique ID for the currency conversion
        /// </summary>
        public int CurrencyConversionId { get; set; }
        /// <summary>
        /// The source currency when converting to the base currency
        /// </summary>
        public int FromCurrencyId { get; set; }
        /// <summary>
        /// The date of the exchange rate
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// The exchange rate 
        /// </summary>
        public double ConversionFactor { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int ToCurrencyId { get; set; }

        public virtual Currency FromCurrency { get; set; }
        public virtual Currency ToCurrency { get; set; }
    }
}
