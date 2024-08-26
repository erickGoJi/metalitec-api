using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemreservationStatus
    {
        public int ItemReservationId { get; set; }
        public byte ReservationType { get; set; }
        public bool MultiContract { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public int? ProjectId { get; set; }
        public string Project { get; set; }
        public int? ContractId { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public int? PhaseId { get; set; }
        public string PhaseName { get; set; }
        public string LotName { get; set; }
        public string MarkName { get; set; }
        public string Allocation { get; set; }
    }
}
