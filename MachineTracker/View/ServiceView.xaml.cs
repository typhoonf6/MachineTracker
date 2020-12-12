using System.Windows.Controls;

namespace MachineTracker
{
    /// <summary>
    /// Interaction logic for ServiceView.xaml
    /// </summary>
    public partial class ServiceView : UserControl
    {
        public ServiceView()
        {
            InitializeComponent();

            DataContext = new ServiceViewModel();
        }
    }
}
