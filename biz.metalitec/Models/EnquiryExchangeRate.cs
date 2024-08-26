using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EnquiryExchangeRate
    {
        public int? AsQuoteId { get; set; }
        public int? EnquiryId { get; set; }
        public double? ExchangeRate { get; set; }
    }
}
