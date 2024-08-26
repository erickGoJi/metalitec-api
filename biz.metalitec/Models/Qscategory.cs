using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Qscategory
    {
        public Qscategory()
        {
            QscategoryRules = new HashSet<QscategoryRule>();
            QscategorySetCategories = new HashSet<QscategorySetCategory>();
            QscategoryUnits = new HashSet<QscategoryUnit>();
        }

        public int QscategoryId { get; set; }
        /// <summary>
        /// Category for Estimating (1) or Contract (2)
        /// </summary>
        public int? QstypeId { get; set; }
        /// <summary>
        /// Category Name e.g. &quot;All Beams&quot;
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Long Description of Category
        /// </summary>
        public string Description { get; set; }
        public int UnitId { get; set; }
        public string Notes { get; set; }
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
        /// <summary>
        /// Order to appear in
        /// </summary>
        public int Version { get; set; }
        public int? TempKey { get; set; }
        public int? CategoryTypeId { get; set; }

        public virtual ICollection<QscategoryRule> QscategoryRules { get; set; }
        public virtual ICollection<QscategorySetCategory> QscategorySetCategories { get; set; }
        public virtual ICollection<QscategoryUnit> QscategoryUnits { get; set; }
    }
}
