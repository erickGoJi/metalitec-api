using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwCurrencyconversionList
    {
        public int FromCurrencyId { get; set; }
        public int ToCurrencyId { get; set; }
        public double ConversionFactor { get; set; }
        public DateTime Date { get; set; }
    }
}
