using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryExchangeLink
    {
        /// <summary>
        /// This can link on ItemInventoryTransactionLine Or PurchaseOrderItemExchange
        /// </summary>
        public int TransActionLineId { get; set; }
        /// <summary>
        /// This can link on ItemInventoryTransactionLine Or PurchaseOrderItemExchange
        /// </summary>
        public int ExchangedTransActionLineId { get; set; }
        public int ExchangedTransActionLineTypeId { get; set; }
        public int TransActionLineTypeId { get; set; }
    }
}
