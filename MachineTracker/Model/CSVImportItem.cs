using System;

namespace MachineTracker
{
    /// <summary>
    /// An object containing the fields imported from CSV data
    /// </summary>
    class CSVImportItem
    {
        /// <summary>
        /// Manufacturer serial number
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// Machine type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Current hours
        /// </summary>
        public int OperatingHours { get; set; }

        /// <summary>
        /// Represents the current state of the machine
        /// </summary>
        public string Workstate { get; set; }

        /// <summary>
        /// Represents the current monitoring status of the machine
        /// </summary>
        public string MonitoringStatus { get; set; }

        /// <summary>
        /// Status of the machine 
        /// </summary>
        public string InMaintStatus { get; set; }

        /// <summary>
        /// Service agreement
        /// </summary>
        public string ServAgreement { get; set; }

        /// <summary>
        /// Local serial number
        /// </summary>
        public string CustomerDesignation { get; set; }

        /// <summary>
        /// Number of satellites connected
        /// </summary>
        public int GPSSatellites { get; set; }

        /// <summary>
        /// Brand of the machine
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Owner of the machine
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Next maintenance due
        /// </summary>
        public int MaintExpectedHours { get; set; }

        /// <summary>
        /// Date next maintenance is due
        /// </summary>
        public DateTime MaintExpectedDate { get; set; }

        /// <summary>
        /// Type of maintenance to be performed
        /// </summary>
        public string MaintType { get; set; }

        /// <summary>
        /// Software version
        /// </summary>
        public string SoftwareVersion { get; set; }
        
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="workstate"></param>
        /// <param name="monitoringStatus"></param>
        /// <param name="inMaintStatus"></param>
        /// <param name="serialNo"></param>
        /// <param name="customerDesignation"></param>
        /// <param name="type"></param>
        /// <param name="operatingHours"></param>
        /// <param name="gPSSatellites"></param>
        /// <param name="brand"></param>
        /// <param name="owner"></param>
        /// <param name="maintExpectedHours"></param>
        /// <param name="maintExpectedDate"></param>
        /// <param name="maintType"></param>
        /// <param name="softwareVersion"></param>
        public CSVImportItem(string serialNo, string brand, string type, int operatingHours, 
            string workstate, string monitoringStatus, string inMaintStatus, 
            string customerDesignation, int gPSSatellites, string owner, int maintExpectedHours, 
            DateTime maintExpectedDate, string maintType, string softwareVersion)
        {
            Workstate = workstate;
            MonitoringStatus = monitoringStatus;
            InMaintStatus = inMaintStatus;
            SerialNo = serialNo;
            CustomerDesignation = customerDesignation;
            Type = type;
            OperatingHours = operatingHours;
            GPSSatellites = gPSSatellites;
            Brand = brand;
            Owner = owner;
            MaintExpectedHours = maintExpectedHours;
            MaintExpectedDate = maintExpectedDate;
            MaintType = maintType;
            SoftwareVersion = softwareVersion;
        }

        /// <summary>
        /// Second constructor just to allow instantiation
        /// </summary>
        public CSVImportItem()
        {

        }
    }
}
