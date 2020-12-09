namespace MachineTracker
{
    /// <summary>
    /// Current life of the machine
    /// </summary>
    class MachineLife
    {
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
        public Datetime NextServiceDate { get; set; }
    }
}
