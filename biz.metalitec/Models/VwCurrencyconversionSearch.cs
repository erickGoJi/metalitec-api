using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwCurrencyconversionSearch
    {
        public int CurrencyConversionId { get; set; }
        public int FromCurrencyId { get; set; }
        public string FromCurrency { get; set; }
        public int ToCurrencyId { get; set; }
        public string ToCurrency { get; set; }
        public DateTime Date { get; set; }
        public double ConversionFactor { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
    }
}
