using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Region
    {
        public Region()
        {
            Grades = new HashSet<Grade>();
            Items = new HashSet<Item>();
            SectionTypes = new HashSet<SectionType>();
        }

        /// <summary>
        /// The unique Region ID number generated automatically
        /// </summary>
        public int RegionId { get; set; }
        /// <summary>
        /// Region Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Description or Name of Region
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Enabled flag determines if Region is enabled or not.
        /// </summary>
        public byte? Enabled { get; set; }
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
        public int Version { get; set; }
        public byte System { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<SectionType> SectionTypes { get; set; }
    }
}
