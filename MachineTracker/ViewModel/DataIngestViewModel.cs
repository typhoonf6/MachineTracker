using Microsoft.Win32;
using System.Windows.Input;

namespace MachineTracker
{
    class DataIngestViewModel : BaseViewModel
    {
        public ICommand FileBrowserCommand { get; set; }

        public ICommand BeginIngestCommand { get; set; }

        public string CSVPath { get; set; }

        private readonly DatabaseContext Context;

        public DataIngestViewModel()
        {
            FileBrowserCommand = new RelayCommand(OpenFileBrowser);
            BeginIngestCommand = new RelayCommand(BeginIngest);
            Context = new DatabaseContext();
        }

        private void BeginIngest()
        {
            Context.Database.EnsureCreated();
            CSVHelper.IngestCSV(CSVPath, Context);
            Context.SaveChanges();
        }

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
