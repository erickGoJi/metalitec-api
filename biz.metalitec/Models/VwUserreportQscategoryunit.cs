using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportQscategoryunit
    {
        public int QscategoryUnitId { get; set; }
        public int QscategoryId { get; set; }
        public string CategoryUnitPrice { get; set; }
        public int CostPriceUnit { get; set; }
        public double CostUnitQuantity { get; set; }
        public double CostUnitPrice { get; set; }
        public int SellPriceUnit { get; set; }
        public double SellUnitQuantity { get; set; }
        public double SellUnitPrice { get; set; }
    }
}
