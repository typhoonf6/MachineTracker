using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MachineTracker
{
    /// <summary>
    /// A status enum
    /// </summary>
    enum Status
    {
        ok,
        inMaint,
        overdue
    }

    /// <summary>
    /// Machine object
    /// </summary>
    class Machine
    {
        /// <summary>
        /// The number of the machine. Must be unique.
        /// </summary>
        [Key, Required]
        public string UnitNo { get; set; }

        /// <summary>
        /// Serial number of the machine
        /// </summary>
        [Required]
        public string Serial { get; set; }

        /// <summary>
        /// The location of the machine. Default is unknown.
        /// </summary>
        public string Location { get; set; } = "Unknown";

        /// <summary>
        /// Type of machine
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Status of the machine <see cref="Status"/>
        /// </summary>
        public Status Status { get; set; } = Status.ok;

        /// <summary>
        /// Object containing the current life of the machine
        /// </summary>
        public virtual MachineLife MachineLife { get; set; }

        /// <summary>
        /// Service history list
        /// </summary>
        public virtual ICollection<ServiceHistory> ServiceHistory { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Machine()
        {
            this.ServiceHistory = new List<ServiceHistory>();
            this.MachineLife = new MachineLife();
        }
    }
}
