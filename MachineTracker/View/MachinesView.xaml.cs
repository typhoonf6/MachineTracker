using System.Windows;
using System.Windows.Controls;

namespace MachineTracker
{
    /// <summary>
    /// Interaction logic for MachinesView.xaml
    /// </summary>
    public partial class MachinesView : UserControl
    {
        public MachinesView()
        {
            InitializeComponent();

            DataContext = new MachinesViewModel();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
    }
}
