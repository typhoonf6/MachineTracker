namespace MachineTracker
{
    /// <summary>
    /// Service history entry of the machine
    /// </summary>
    class ServiceHistory
    {
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
        public Datetime CarriedOutDate { get; set; }

        /// <summary>
        /// The employee that carried out the service
        /// </summary>
        public Employee CarriedOutBy { get; set; }

        /// <summary>
        /// Who entered the data
        /// </summary>
        public Employee EnteredBy { get; set; }
    }
}
