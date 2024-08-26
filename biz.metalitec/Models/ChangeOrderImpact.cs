using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderImpact
    {
        public int ChangeOrderImpactId { get; set; }
        public int ChangeOrderId { get; set; }
        public string Schedule { get; set; }
        public string Fabrication { get; set; }
        public string Material { get; set; }
        public string Design { get; set; }
        public string Treatment { get; set; }
        public string Management { get; set; }
        public string Equipment { get; set; }
        public string BoughtOutItems { get; set; }
        public string DrawingOffice { get; set; }
        public string SiteWorks { get; set; }
        public string SubContractor { get; set; }
        public string Shipping { get; set; }
        public string GeneralConditions { get; set; }
        public string Other { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
    }
}
