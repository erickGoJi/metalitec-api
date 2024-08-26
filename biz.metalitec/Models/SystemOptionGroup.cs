using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemOptionGroup
    {
        public SystemOptionGroup()
        {
            SystemOptions = new HashSet<SystemOption>();
        }

        /// <summary>
        /// Unique ID automatically generated
        /// </summary>
        public int SystemOptionGroupId { get; set; }
        /// <summary>
        /// System Option Group Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
        public int SortOrder { get; set; }
        /// <summary>
        /// System Field
        /// </summary>
        public byte System { get; set; }

        public virtual ICollection<SystemOption> SystemOptions { get; set; }
    }
}
