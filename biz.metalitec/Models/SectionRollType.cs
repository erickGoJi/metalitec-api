using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SectionRollType
    {
        public SectionRollType()
        {
            EstimateExtras = new HashSet<EstimateExtra>();
            Extras = new HashSet<Extra>();
            SectionTypes = new HashSet<SectionType>();
        }

        public int SectionRollTypeId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte? System { get; set; }

        public virtual ICollection<EstimateExtra> EstimateExtras { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<SectionType> SectionTypes { get; set; }
    }
}
