using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObject
    {
        public SystemObject()
        {
            RoleObjectActions = new HashSet<RoleObjectAction>();
            RoleObjects = new HashSet<RoleObject>();
            SystemModuleGroupObjects = new HashSet<SystemModuleGroupObject>();
            SystemModuleObjects = new HashSet<SystemModuleObject>();
            SystemObjectActions = new HashSet<SystemObjectAction>();
            SystemObjectAttachments = new HashSet<SystemObjectAttachment>();
            SystemObjectUserRestrictions = new HashSet<SystemObjectUserRestriction>();
        }

        public int SystemObjectId { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }
        public string MenuName { get; set; }
        public string SearchFormName { get; set; }
        public string DialogFormName { get; set; }
        public int Searchable { get; set; }
        public int? Sort { get; set; }
        public byte System { get; set; }
        public bool IsNavigationFormTask { get; set; }
        public bool IsNavigationFormSearch { get; set; }
        public string NavigationFormCaption { get; set; }
        public int? ParentSystemObjectId { get; set; }
        public bool NotificationOnInsert { get; set; }
        public bool NotificationOnUpdate { get; set; }
        public bool NotificationOnDelete { get; set; }
        public bool? FacilityRestricted { get; set; }

        public virtual ICollection<RoleObjectAction> RoleObjectActions { get; set; }
        public virtual ICollection<RoleObject> RoleObjects { get; set; }
        public virtual ICollection<SystemModuleGroupObject> SystemModuleGroupObjects { get; set; }
        public virtual ICollection<SystemModuleObject> SystemModuleObjects { get; set; }
        public virtual ICollection<SystemObjectAction> SystemObjectActions { get; set; }
        public virtual ICollection<SystemObjectAttachment> SystemObjectAttachments { get; set; }
        public virtual ICollection<SystemObjectUserRestriction> SystemObjectUserRestrictions { get; set; }
    }
}
