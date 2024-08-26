using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemUpdate
    {
        public int SystemUpdateId { get; set; }
        public string Version { get; set; }
        public byte[] File { get; set; }
        /// <summary>
        /// ~1 - Server Only, 2 - Server and Client 
        /// </summary>
        public byte UpdateType { get; set; }
        /// <summary>
        /// ~0 - False , 1 - True
        /// </summary>
        public byte Installed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
