﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportInventoryadjustmentitem
    {
        public int InventoryAdjustmentItemId { get; set; }
        public int InventoryAdjustmentId { get; set; }
        public string LineType { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public int? ContractMarkId { get; set; }
        public string Mark { get; set; }
        public int? ContractMarkItemId { get; set; }
        public string MarkItem { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public string ItemClassification { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string PriceUnit { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string PurchaseOrder { get; set; }
        public string PurchaseOrderReceipt { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public byte Complete { get; set; }
        public string Allocation { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
    }
}
