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
            MenuItems = new List<MenuItem>
            {
                new MenuItem("Service View", MaterialDesignThemes.Wpf.PackIconKind.Database),
                new MenuItem("View All", MaterialDesignThemes.Wpf.PackIconKind.User)
            };
        }
    }
}
