using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleObjectActions = new HashSet<RoleObjectAction>();
            RoleObjects = new HashSet<RoleObject>();
            RoleReports = new HashSet<RoleReport>();
            UserRoles = new HashSet<UserRole>();
        }

        /// <summary>
        /// Unique role ID number
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Name of the role
        /// </summary>
        public string Name { get; set; }
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
        public int System { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<RoleObjectAction> RoleObjectActions { get; set; }
        public virtual ICollection<RoleObject> RoleObjects { get; set; }
        public virtual ICollection<RoleReport> RoleReports { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
