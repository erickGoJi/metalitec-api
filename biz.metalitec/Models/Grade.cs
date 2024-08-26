using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Items = new HashSet<Item>();
        }

        /// <summary>
        /// Unique grade ID number
        /// </summary>
        public int GradeId { get; set; }
        /// <summary>
        /// Name of grade
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Region of grade
        /// </summary>
        public int RegionId { get; set; }
        public int Rating { get; set; }
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

        public virtual Region Region { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
