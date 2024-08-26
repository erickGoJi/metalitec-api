using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractItemCam
    {
        public int ContractItemCamid { get; set; }
        public int ContractItemId { get; set; }
        public string FileName { get; set; }
        public DateTime FileCreateDate { get; set; }
        public DateTime FileLastModifiedDate { get; set; }
        public string Camxml { get; set; }
        public int CamProcesses { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        public string Notes { get; set; }
        public int Version { get; set; }
        public bool? HasSimpleCut { get; set; }
        public bool? HasAngleCut { get; set; }
        public bool? HasContourCut { get; set; }
        public bool? HasScribing { get; set; }
        public bool? HasStamping { get; set; }
        public bool? HasPopMark { get; set; }
        public bool? HasHole { get; set; }
        public bool? HasThreadedHole { get; set; }
        public bool? HasBlindHole { get; set; }
        public bool? HasCountersunkHole { get; set; }
        public bool? HasSlot { get; set; }
        public double? StartWebAngle { get; set; }
        public double? EndWebAngle { get; set; }
        public double? StartTopFlangeAngle { get; set; }
        public double? EndTopFlangeAngle { get; set; }
        public double? StartBottomFlangeAngle { get; set; }
        public double? EndBottomFlangeAngle { get; set; }
        public int? HoleCount { get; set; }
        public double? MinHoleDiameter { get; set; }
        public double? MaxHoleDiameter { get; set; }
        public bool? MasterCam { get; set; }
        public string SessionGuid { get; set; }
        public bool NestedCam { get; set; }
        public bool WorkOrderCam { get; set; }
        public int? ProductionProcessId { get; set; }
        public int? WorkstationId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public bool StrumisGenerated { get; set; }
        public short? Camformat { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? SawingLength { get; set; }
        public string WebFrontHoleDiameters { get; set; }
        public string WebRearHoleDiameters { get; set; }
        public string TopFlangeHoleDiameters { get; set; }
        public string BottomFlangeHoleDiameters { get; set; }

        public virtual ContractItem ContractItem { get; set; }
    }
}
