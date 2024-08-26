using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderArchiveLink
    {
        public int ContractId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public bool FullyArchived { get; set; }
    }
}
