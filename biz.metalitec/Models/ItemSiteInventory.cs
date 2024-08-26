using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSiteInventory
    {
        public ItemSiteInventory()
        {
            ItemSiteInventoryInstances = new HashSet<ItemSiteInventoryInstance>();
        }

        public int ItemSiteInventoryId { get; set; }
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int UnitId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public int ItemInventoryPropertyId { get; set; }
        public int? FacilityId { get; set; }
        public int? CurrencyId { get; set; }
        public string TmpKey { get; set; }

        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemInventoryProperty ItemInventoryProperty { get; set; }
        public virtual ItemInventoryShape ItemInventoryShape { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ContractMark Mark { get; set; }
        public virtual ContractMarkItem MarkItem { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ItemSiteInventoryInstance> ItemSiteInventoryInstances { get; set; }
    }
}
