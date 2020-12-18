using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace MachineTracker
{
    /// <summary>
    /// Class that contains static methods for processing the CSV data for import
    /// </summary>
    class CSVHelper
    {
        
        // TODO CSVIMPORT: Make this asynchronous

        /// <summary>
        /// Attempts to read in CSV data from the specified location
        /// </summary>
        /// <param name="fileLocation"></param>
        /// <param name="context"></param>
        public static ObservableCollection<CSVImportItem> IngestCSV(string fileLocation)
        {
            var dataTable = new DataTable();
            var csvImportList = new ObservableCollection<CSVImportItem>();
            using var reader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true, ';');
            dataTable.Load(reader);

            foreach (DataRow row in dataTable.Rows)
            {
                try
                {
                    csvImportList.Add(new CSVImportItem
                    {
                        Workstate = row["Workstate"].ToString(),
                        MonitoringStatus = row["Monitoring Status"].ToString(),
                        InMaintStatus = row["In maint. status"].ToString(),
                        ServAgreement = row["Serv. agreement"].ToString(),
                        SerialNo = row["S/N"].ToString(),
                        CustomerDesignation = row["Customer designation"].ToString(),
                        Type = row["Type / appendix"].ToString(),
                        OperatingHours = IntConverter(row["Operating hours[h]"].ToString()),
                        GPSSatellites = IntConverter(row["GPS number of satellites"].ToString()),
                        Brand = row["Brand"].ToString(),
                        Owner = row["Owner"].ToString(),
                        MaintExpectedHours = IntConverter(row["Maintenance expected in[d]"].ToString()),
                        MaintExpectedDate = DateConverter(row["Maintenance expected on"].ToString()),
                        MaintType = row["Maint. type (OH)"].ToString(),
                        SoftwareVersion = row["Software version TCU"].ToString()
                    });
                }
                catch
                {
                    // TODO CSVIMPORT: Count and return rows that had errors processing
                    // TODO CSVIMPORT: Re Jig the import to handle errors better
                    continue;
                }
                
                // Check for the machine existing
                /*
                if (!context.Machines.Any(x => x.UnitNo == row[8].ToString()))
                {
                    context.Machines.Local.Add(new Machine { UnitNo = row[8].ToString(), Serial = row[7].ToString() });
                }
                */
            }

            dataTable.Dispose();

            return csvImportList;
        }

        /// <summary>
        /// Attempts to parse the date and returns the value, else it returns a default date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static DateTime DateConverter(string date)
        {
            var culture = new CultureInfo("en-US");

            try
            {
                return DateTime.Parse(date, culture);
            }
            catch
            {
                return new DateTime(2000, 01, 01);
            }
        }

        /// <summary>
        /// Attempts to parse the integer, if there is an exception, returns 0
        /// </summary>
        /// <param name="integer"></param>
        /// <returns></returns>
        private static int IntConverter(string integer)
        {
            try
            {
                return int.Parse(integer);
            }
            catch
            {
                return -1;
            }
        }
    }
}
