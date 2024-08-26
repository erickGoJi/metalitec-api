using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempProductionWorkOrderTemplate
    {
        public int ProductionWorkOrderTemplateId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int ProductionTemplateId { get; set; }
        public bool Active { get; set; }
        public int? FailedRuleId { get; set; }
        public string Actual { get; set; }
        public int? FailedItemLocationId { get; set; }
        public int? FailedProcessId { get; set; }
        /// <summary>
        /// This column is used to group work orders together by their (MarkID, TransactionID, BundleID, CuttingPlanID)
        /// </summary>
        public int? GroupPwoId { get; set; }
        /// <summary>
        /// This column is used to group work order templates together by their (MarkID, TransactionID, BundleID, CuttingPlanID)
        /// </summary>
        public int? GroupPwotId { get; set; }

        public virtual TempProductionWorkOrder ProductionWorkOrder { get; set; }
    }
}
