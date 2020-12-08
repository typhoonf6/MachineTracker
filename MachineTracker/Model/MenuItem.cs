using MaterialDesignThemes.Wpf;

namespace MachineTracker
{
    /// <summary>
    /// Items to be placed in the nav drawer
    /// </summary>
    class MenuItem
    {
        /// <summary>
        /// Displayed as the menu item
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Material design icon to be displayed beside text
        /// </summary>
        public PackIconKind Icon { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name">Name to be displayed</param>
        /// <param name="icon">Material Design Icon</param>
        public MenuItem(string name, PackIconKind icon)
        {
            Name = name;
            Icon = icon;
        }
    }
}
