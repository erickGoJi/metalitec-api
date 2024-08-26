using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionPackageItemArchive
    {
        public int ProductionPackageItemId { get; set; }
        public int ProductionPackageId { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? FromProductionProcessId { get; set; }
        public int? ToProductionProcessId { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double? Weight { get; set; }
        public string Notes { get; set; }
        public int? TransactionLineId { get; set; }

        public virtual ProductionProcess FromProductionProcess { get; set; }
        public virtual ProductionPackage ProductionPackage { get; set; }
        public virtual ProductionProcess ToProductionProcess { get; set; }
    }
}
