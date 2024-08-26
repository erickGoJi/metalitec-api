using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemreservationDetail
    {
        public int ItemReservationId { get; set; }
        public byte ReservationType { get; set; }
        public string Allocation { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int? PhaseId { get; set; }
        public string Phase { get; set; }
        public int? ContractPrelimBatchId { get; set; }
    }
}
