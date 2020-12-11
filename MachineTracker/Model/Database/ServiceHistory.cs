using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MachineTracker
{
    /// <summary>
    /// Service history entry of the machine
    /// </summary>
    class ServiceHistory
    {
        /// <summary>
        /// Identifier for the service history entry
        /// </summary>
        public int ServiceHistoryID { get; set; }

        /// <summary>
        /// When the service was due
        /// </summary>
        public double HoursDue { get; set; }

        /// <summary>
        /// When the service was carried out
        /// </summary>
        public double CarriedOutHours { get; set; }

        /// <summary>
        /// What date the service was carried out
        /// </summary>
        public DateTime CarriedOutDate { get; set; }

        /// <summary>
        /// The employee that carried out the service
        /// </summary>
        public Employee CarriedOutBy { get; set; }

        /// <summary>
        /// Who entered the data
        /// </summary>
        public Employee EnteredBy { get; set; }

        /// <summary>
        /// Link to the machine this is associated with
        /// </summary>
        [ForeignKey("UnitNo")]
        public virtual Machine Machine { get; set; }
    }
}
