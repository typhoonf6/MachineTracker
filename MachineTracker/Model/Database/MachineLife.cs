﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTracker
{
    /// <summary>
    /// Current life of the machine
    /// </summary>
    class MachineLife
    {
        /// <summary>
        /// Identifier for this lifing data
        /// </summary>
        public int CurrentLifeID { get; set; }

        /// <summary>
        /// Current Hours
        /// </summary>
        public double Hours { get; set; }

        /// <summary>
        /// Next service due hours
        /// </summary>
        public double NextServiceHours { get; set; }

        /// <summary>
        /// Next service due date
        /// </summary>
        public DateTime NextServiceDate { get; set; }

        /// <summary>
        /// Link to the machine this is associated with
        /// </summary>
        [ForeignKey("UnitNo")]
        public virtual Machine Machine { get; set; }
    }
}