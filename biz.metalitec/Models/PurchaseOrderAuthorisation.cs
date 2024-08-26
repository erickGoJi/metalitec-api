using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseOrderAuthorisation
    {
        public int PurchaseOrderAuthorisationId { get; set; }
        public int PurchaseOrderId { get; set; }
        public string PurchaseOrderGuid { get; set; }
        public int PurchaseOrderVersion { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
