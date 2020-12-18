using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTracker
{
    /// <summary>
    /// A status enum
    /// </summary>
    public enum Status
    {
        ok,
        inMaint,
        overdue
    }

    /// <summary>
    /// Machine object
    /// </summary>
    public class Machine
    {
        /// <summary>
        /// Database set ID for the entity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MachineID { get; set; }

        /// <summary>
        /// The number of the machine. Must be unique.
        /// </summary>
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
        public Status? Status { get; set; }

        /// <summary>
        /// Object containing the current life of the machine
        /// </summary>
        public virtual MachineLife MachineLife { get; set; }

        /// <summary>
        /// Service history list
        /// </summary>
        public virtual ICollection<ServiceHistory> ServiceHistory { get; set; }

        /// <summary>
        /// Sets whether the machine is active
        /// </summary>
        public bool Active { get; set; } = true;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Machine()
        {
            this.MachineLife = new MachineLife();
            this.ServiceHistory = new HashSet<ServiceHistory>();
        }
    }
}
