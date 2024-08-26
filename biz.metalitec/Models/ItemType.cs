using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            Items = new HashSet<Item>();
        }

        public int ItemTypeId { get; set; }
        /// <summary>
        /// Name of the Item Type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Steel Item flag
        /// </summary>
        public byte SteelItem { get; set; }
        public byte? System { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }
}
