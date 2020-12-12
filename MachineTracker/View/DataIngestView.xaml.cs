using System.Windows.Controls;

namespace MachineTracker
{
    /// <summary>
    /// Interaction logic for DataIngestView.xaml
    /// </summary>
    public partial class DataIngestView : UserControl
    {
        public DataIngestView()
        {
            InitializeComponent();

            DataContext = new DataIngestViewModel();
        }
    }
}
