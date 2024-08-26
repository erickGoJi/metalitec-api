using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QscategorySet
    {
        public QscategorySet()
        {
            QscategorySetCategories = new HashSet<QscategorySetCategory>();
        }

        public int QscategorySetId { get; set; }
        /// <summary>
        /// Category for Estimating (1) or Contract (2)
        /// </summary>
        public byte QstypeId { get; set; }
        /// <summary>
        /// The Name of the Category Set
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the Category Set
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }

        public virtual ICollection<QscategorySetCategory> QscategorySetCategories { get; set; }
    }
}
