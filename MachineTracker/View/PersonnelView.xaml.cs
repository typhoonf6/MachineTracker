using System.Windows.Controls;

namespace MachineTracker
{
    /// <summary>
    /// Interaction logic for PersonnelView.xaml
    /// </summary>
    public partial class PersonnelView : UserControl
    {
        public PersonnelView()
        {
            InitializeComponent();

            DataContext = new PersonnelViewModel();
        }
    }
}
