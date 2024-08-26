using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class LanguageString
    {
        public int LanguageStringId { get; set; }
        public string SystemString { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? System { get; set; }
    }
}
