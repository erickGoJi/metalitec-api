using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class InventoryBarcodeListing
    {
        public int InventoryBarcodeListingId { get; set; }
        public int BarcodeInterfaceId { get; set; }
        public string SessionGuid { get; set; }
        public bool? Valid { get; set; }
        public int? CuttingPlan { get; set; }
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int? ItemId { get; set; }
        public string Process { get; set; }
        public int? ProductionProcessId { get; set; }
        public string MarkItem { get; set; }
        public string WorkOrder { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? ItemInventoryId { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public string ErrorMessage { get; set; }
        public string ScannedBy { get; set; }
        public DateTime ScannedOn { get; set; }
        public bool? ActiveBarcode { get; set; }
        public double? Area { get; set; }
        public string Barcode { get; set; }
        public bool Ignore { get; set; }
        /// <summary>
        /// ~~(1=Inventory Barcode, 2=Inventory Reconciliation)
        /// </summary>
        public byte InventoryListingTypeId { get; set; }
        public string ItemLocation { get; set; }
        public double? Length { get; set; }
        public int? RevisionIndex { get; set; }
        public byte? RevisionStatus { get; set; }
        public double? Width { get; set; }
    }
}
