using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempProductionWorkOrder
    {
        public TempProductionWorkOrder()
        {
            TempProductionWorkOrderTemplates = new HashSet<TempProductionWorkOrderTemplate>();
        }

        public int ProductionWorkOrderId { get; set; }
        public string SessionGuid { get; set; }
        public int? MarkId { get; set; }
        public int? ContractItemId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public double? Quantity { get; set; }
        public bool? UseCam { get; set; }
        public int? LinkId { get; set; }
        public int? ProductionWorkOrderTemplateId { get; set; }
        public int? LotId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public bool? IsAssemblyMark { get; set; }
        public int? FacilityId { get; set; }
        public int? ContractMarkInstanceId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        /// <summary>
        /// This column is used to group work orders together by their (MarkID, TransactionID, BundleID, CuttingPlanID)
        /// </summary>
        public int? GroupPwoId { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ICollection<TempProductionWorkOrderTemplate> TempProductionWorkOrderTemplates { get; set; }
    }
}
