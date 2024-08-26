using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserLoginHistory
    {
        public int UserLoginHistoryId { get; set; }
        public string UserName { get; set; }
        public string MachineName { get; set; }
        public Guid? SessionId { get; set; }
        public long LicensesUsed { get; set; }
        public DateTime LoginDateTime { get; set; }
        public DateTime? LastPulseTime { get; set; }
        public DateTime? LogoutDateTime { get; set; }
        public long? Licences { get; set; }
        public string LoginError { get; set; }
    }
}
