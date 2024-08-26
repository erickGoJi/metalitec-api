using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryHistory
    {
        public ItemInventoryHistory()
        {
            ItemInventoryInstanceHistories = new HashSet<ItemInventoryInstanceHistory>();
        }

        public int ItemInventoryHistoryId { get; set; }
        public int ItemInventoryId { get; set; }
        public int ItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int ItemLocationId { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public int ItemInventoryPropertyId { get; set; }
        public int FacilityId { get; set; }
        public DateTime? DateLogged { get; set; }

        public virtual ICollection<ItemInventoryInstanceHistory> ItemInventoryInstanceHistories { get; set; }
    }
}
