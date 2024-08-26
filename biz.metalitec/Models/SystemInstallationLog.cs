using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemInstallationLog
    {
        public int SystemInstallationLogId { get; set; }
        /// <summary>
        /// The version that the database has been upgraded to
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// The name of the hotfix that was loaded
        /// </summary>
        public string HotfixVersion { get; set; }
        /// <summary>
        /// The version of the script file
        /// </summary>
        public string ScriptVersion { get; set; }
        /// <summary>
        /// 1 = This is a hotfix, 0 - This is not  a hotfix
        /// </summary>
        public bool IsHotfix { get; set; }
        /// <summary>
        /// The date the upgrade was run
        /// </summary>
        public DateTime InstalledOn { get; set; }
        public string Notes { get; set; }
    }
}
