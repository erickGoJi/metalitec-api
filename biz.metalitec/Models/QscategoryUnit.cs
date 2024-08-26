using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QscategoryUnit
    {
        public int QscategoryUnitId { get; set; }
        public int QscategoryId { get; set; }
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
        /// Sell Unit ID
        /// </summary>
        public int SellUnitId { get; set; }
        public double SellUnitQuantity { get; set; }
        /// <summary>
        /// The Sell Unit Price
        /// </summary>
        public double SellUnitPrice { get; set; }
        public int Sort { get; set; }

        public virtual Qscategory Qscategory { get; set; }
    }
}
