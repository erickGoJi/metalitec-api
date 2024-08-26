using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractDrawing
    {
        public ContractDrawing()
        {
            ContractMarks = new HashSet<ContractMark>();
        }

        public int ContractDrawingId { get; set; }
        public int ContractListingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Revision { get; set; }
        public DateTime? DrawingDate { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string IssuedBy { get; set; }
        public string CheckedBy { get; set; }
        public int Version { get; set; }
        public string RevisedBy { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual ICollection<ContractMark> ContractMarks { get; set; }
    }
}
