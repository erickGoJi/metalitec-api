using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemCrossReference
    {
        public int ItemCrossReferenceId { get; set; }
        public int ItemId { get; set; }
        /// <summary>
        /// Select the cross reference type; Cad Interface or Supplier.
        /// </summary>
        public int CrossReferenceTypeId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Enter any notes you wish to add to the cross reference.
        /// </summary>
        public string Notes { get; set; }
        public byte? RnU { get; set; }

        public virtual Item Item { get; set; }
    }
}
