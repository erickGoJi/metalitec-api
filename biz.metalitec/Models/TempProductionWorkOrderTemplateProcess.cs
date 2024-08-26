using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempProductionWorkOrderTemplateProcess
    {
        public int? ProductionWorkOrderTemplateId { get; set; }
        public int ProductionProcessId { get; set; }
        public int? Quantity { get; set; }
        public double? HourlyRate { get; set; }
        public double? PerUnitMinutes { get; set; }
        public double? FixedMinutes { get; set; }
        public string ProductionStage { get; set; }
        public int DefaultProductionWorkStationId { get; set; }
        public string WorkStation { get; set; }
        public int? DefaultItemLocationId { get; set; }
        public string ItemLocation { get; set; }
        public bool? RequiresWorkStation { get; set; }
        public int? ProcessNumber { get; set; }
        public byte? DisplayTimeUnitId { get; set; }
        public int? ProductionTemplateProcessId { get; set; }
        public byte? ItemLocationTypeId { get; set; }
        /// <summary>
        /// This column is used to group work order templates together by their (MarkID, TransactionID, BundleID, CuttingPlanID)
        /// </summary>
        public int? GroupPwotId { get; set; }

        public virtual TempProductionWorkOrderTemplate ProductionWorkOrderTemplate { get; set; }
    }
}
