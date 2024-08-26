using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserJobTitle { get; set; }
        public string UserEMailAddress { get; set; }
        public string UserTelephone { get; set; }
        public string Language { get; set; }
        public int Active { get; set; }
        public DateTime Expires { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string UserNotes { get; set; }
    }
}
