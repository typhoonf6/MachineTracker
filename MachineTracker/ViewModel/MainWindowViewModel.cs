﻿using System.Collections.Generic;

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
        public object SelectedView { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MainWindowViewModel()
        {
            SelectedView = new MachinesViewModel();

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
