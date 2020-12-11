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
            Context.Machines.Load();
            Machines = Context.Machines.Local.ToObservableCollection();
        }
    }
}
