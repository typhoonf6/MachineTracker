﻿using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MachineTracker
{
    /// <summary>
    /// View model for the DataIngest screen
    /// </summary>
    class DataIngestViewModel : BaseViewModel
    {
        /// <summary>
        /// Command that runs the <see cref="OpenFileBrowser"/> method
        /// </summary>
        public ICommand FileBrowserCommand { get; set; }

        /// <summary>
        /// Command that runs the <see cref="BeginIngest"/> method
        /// </summary>
        public ICommand BeginIngestCommand { get; set; }

        /// <summary>
        /// Bound to the text box on the view
        /// </summary>
        public string CSVPath { get; set; }

        /// <summary>
        /// Database access object
        /// </summary>
        private readonly DatabaseContext Context;

        /// <summary>
        /// Contains imported CSV Data
        /// </summary>
        public ObservableCollection<CSVImportItem> CSVData { get; set; }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataIngestViewModel()
        {
            FileBrowserCommand = new RelayCommand(OpenFileBrowser);
            BeginIngestCommand = new RelayCommand(BeginIngest);
            Context = new DatabaseContext();
            CSVData = new ObservableCollection<CSVImportItem>();
        }

        /// <summary>
        /// Ingests the CSV file and saves it into the database
        /// </summary>
        private async void BeginIngest()
        {
            Context.Database.EnsureCreated();
            CSVData = await Task.Run(() => CSVHelper.IngestCSV(CSVPath));
        }

        /// <summary>
        /// Opens the file browser to allow the user to select a csv file
        /// </summary>
        private void OpenFileBrowser()
        {
            var fd = new OpenFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Open CSV File"
            };

            if (fd.ShowDialog() == true)
            {
                CSVPath = fd.FileName;
            }
        }
    }
}
