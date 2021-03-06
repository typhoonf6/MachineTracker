﻿using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

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
        /// Machine that is selected by the user on the view
        /// </summary>
        public Machine SelectedMachine { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MachinesViewModel()
        {
            Context = new DatabaseContext();

            Machines = new ObservableCollection<Machine>();

            Task.Run(() => LoadMachineData());

            // TODO MACHINESVIEW: Show loading message while datatable is being populated
        }

        /// <summary>
        /// Loads in machine data from the database
        /// </summary>
        private void LoadMachineData()
        { 
            if (Context.Database.CanConnect())
            {
                Context.Machines.Load();
                Machines = Context.Machines.Local.ToObservableCollection();
            }
        }
    }
}
