using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using LumenWorks.Framework.IO.Csv;

namespace MachineTracker
{
    class CSVHelper
    {
        public static void IngestCSV(string fileLocation, DatabaseContext context)
        {
            var dataTable = new DataTable();

            using var reader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true, ';');

            dataTable.Load(reader);

            foreach (DataRow row in dataTable.Rows)
            {
                // Check for the machine existing
                if (!context.Machines.Any(x => x.UnitNo == row[8].ToString()))
                {
                    context.Machines.Local.Add(new Machine { UnitNo = row[8].ToString(), Serial = row[7].ToString() });
                }

                // Update if true, create new if false

                // CREATE: Machine, MachineLife
            }

            dataTable.Dispose();
        }
    }
}
