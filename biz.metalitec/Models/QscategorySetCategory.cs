using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QscategorySetCategory
    {
        public int QscategorySetCategoryId { get; set; }
        /// <summary>
        /// Unique Subsection Set ID number.
        /// </summary>
        public int QscategorySetId { get; set; }
        /// <summary>
        /// The category belonging to the set
        /// </summary>
        public int QscategoryId { get; set; }

        public virtual Qscategory Qscategory { get; set; }
        public virtual QscategorySet QscategorySet { get; set; }
    }
}
