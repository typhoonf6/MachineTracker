using System.Collections.Generic;

namespace MachineTracker
{
    /// <summary>
    /// View Model for the MainWindow
    /// </summary>
    class MainWindowViewModel : BaseViewModel
    {
        /// <summary>
        /// Holds the items for the menu on the nav drawer
        /// </summary>
        public List<MenuItem> MenuItems { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            //var context = new DatabaseContext();

            //context.Database.EnsureCreated();

            //var machine = context.Machines.Add(new Machine { UnitNo = "Test123", Serial = "12345", Status = Status.ok, Type = "Truck" });

            //machine.Entity.MachineLife.Hours = 100;

            //context.SaveChanges();

            MenuItems = new List<MenuItem>
            {
                new MenuItem("Service View", MaterialDesignThemes.Wpf.PackIconKind.Calendar),
                new MenuItem("Machines", MaterialDesignThemes.Wpf.PackIconKind.Tractor),
                new MenuItem("Personnel", MaterialDesignThemes.Wpf.PackIconKind.User),
                new MenuItem("Data Ingest", MaterialDesignThemes.Wpf.PackIconKind.DatabaseAdd)
            };
        }
    }
}
