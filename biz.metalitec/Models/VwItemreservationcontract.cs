using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemreservationcontract
    {
        public int ItemReservationId { get; set; }
        public byte ReservationType { get; set; }
        public bool MultiContract { get; set; }
        public string Allocation { get; set; }
        public int ContractId { get; set; }
        public int? PhaseId { get; set; }
    }
}
