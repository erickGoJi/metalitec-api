using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class User
    {
        public User()
        {
            SystemObjectUserRestrictionUsers = new HashSet<SystemObjectUserRestrictionUser>();
            UserAuthorisationLimits = new HashSet<UserAuthorisationLimit>();
            UserRoles = new HashSet<UserRole>();
        }

        /// <summary>
        /// Unique user ID number
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Enter a unique name for the user.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Set the password for the user.
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Specify the users preferred language.
        /// </summary>
        public int LanguageId { get; set; }
        public int Active { get; set; }
        /// <summary>
        /// Enter the date the users profile expires.
        /// </summary>
        public DateTime Expires { get; set; }
        /// <summary>
        /// Specify the users role within the system.
        /// </summary>
        public int? RoleId { get; set; }
        public DateTime? LastRequest { get; set; }
        public string SessionId { get; set; }
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
        public string Notes { get; set; }
        public int System { get; set; }
        public int? ContactId { get; set; }
        public int? FacilityId { get; set; }
        public double? SinglePurchaseOrderLimit { get; set; }
        public int Version { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ICollection<SystemObjectUserRestrictionUser> SystemObjectUserRestrictionUsers { get; set; }
        public virtual ICollection<UserAuthorisationLimit> UserAuthorisationLimits { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
