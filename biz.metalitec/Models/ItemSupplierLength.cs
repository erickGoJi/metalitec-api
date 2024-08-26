﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSupplierLength
    {
        public int ItemSupplierLengthId { get; set; }
        public int ItemSupplierId { get; set; }
        public double Length { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public double Width { get; set; }

        public virtual ItemSupplier ItemSupplier { get; set; }
    }
}
