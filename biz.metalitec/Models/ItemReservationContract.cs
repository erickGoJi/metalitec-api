﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemReservationContract
    {
        /// <summary>
        /// Unique Item Reservation Contract/Phase ID automatically generated by system.
        /// </summary>
        public int ItemReservationContractId { get; set; }
        /// <summary>
        /// Item Reservation ID this entry is linked to.
        /// </summary>
        public int ItemReservationId { get; set; }
        /// <summary>
        /// Contract ID this entry refers to.
        /// </summary>
        public int ContractId { get; set; }
        /// <summary>
        /// Phase ID this entry refers to.
        /// </summary>
        public int? PhaseId { get; set; }
        public byte? ReservationType { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual ContractPhase Phase { get; set; }
    }
}
