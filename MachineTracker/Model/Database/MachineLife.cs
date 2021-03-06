﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTracker
{
    /// <summary>
    /// Current life of the machine
    /// </summary>
    public class MachineLife
    {
        /// <summary>
        /// Identifier for this lifing data
        /// </summary>
        [Key, ForeignKey("Machine")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MachineLifeID { get; set; }

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
        public virtual Machine Machine { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="hours"></param>
        /// <param name="nextServiceHours"></param>
        public MachineLife(double hours, double nextServiceHours)
        {
            Hours = hours;
            NextServiceHours = nextServiceHours;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MachineLife()
        {

        }
    }
}
