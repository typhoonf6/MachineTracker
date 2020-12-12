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
        /// The view model thats displayed
        /// </summary>
        public object SelectedView { get; set; }

        /// <summary>
        /// The command that runs when a menu item is selected
        /// </summary>
        public ChangeViewCommand ChangeViewCommand { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            ChangeViewCommand = new ChangeViewCommand(this);

            MenuItems = new List<MenuItem>
            {
                new MenuItem("Service View", MaterialDesignThemes.Wpf.PackIconKind.Calendar, "ServiceView"),
                new MenuItem("Machines", MaterialDesignThemes.Wpf.PackIconKind.Tractor, "MachinesView"),
                new MenuItem("Personnel", MaterialDesignThemes.Wpf.PackIconKind.User, "PersonnelView"),
                new MenuItem("Data Ingest", MaterialDesignThemes.Wpf.PackIconKind.DatabaseAdd, "DataIngestView")
            };
        }
    }
}
