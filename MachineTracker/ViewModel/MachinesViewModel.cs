using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace MachineTracker
{
    class MachinesViewModel : BaseViewModel
    {
        /// <summary>
        /// Database access object
        /// </summary>
        private readonly DatabaseContext Context;

        /// <summary>
        /// Machines to bind to the view
        /// </summary>
        public ObservableCollection<Machine> Machines { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MachinesViewModel()
        {
            Context = new DatabaseContext();

            LoadMachineData();

            // CSVHelper.IngestCSV("C:\\Users\\crust\\OneDrive\\Desktop\\Kitch\\Downer+Fleet_selected_2019-08-12_17.csv", Context);

            // Context.SaveChanges();
        }

        private void LoadMachineData()
        {
            Context.Database.EnsureCreated();
            Context.Machines.Load();
            Machines = Context.Machines.Local.ToObservableCollection();
        }
    }
}
