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
        public string ButtonText { get; private set; }

        /// <summary>
        /// Material design icon to be displayed beside text
        /// </summary>
        public PackIconKind Icon { get; private set; }

        /// <summary>
        /// Names the view to pass to the command to change it
        /// </summary>
        public string CommandParameter { get; private set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="name">Name to be displayed</param>
        /// <param name="icon">Material Design Icon</param>
        public MenuItem(string buttonText, PackIconKind icon, string commandParameter)
        {
            ButtonText = buttonText;
            Icon = icon;
            CommandParameter = commandParameter;
        }
    }
}
