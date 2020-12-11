using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace MachineTracker
{
    class CSVHelper
    {
        public void IngestCSV(string fileLocation, DatabaseContext context)
        {
            var dataTable = new DataTable();

            using var reader = new CsvReader(new StreamReader(File.OpenRead(fileLocation)), true);

            dataTable.Load(reader);

            foreach (DataRowCollection row in dataTable.Rows)
            {
                // Check for the machine existing

                // Set up context properly first
                
                // Update if true, create new if false

                // CREATE: Machine, MachineLife
            }

            dataTable.Dispose();
        }
    }
}
