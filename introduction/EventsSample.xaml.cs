using System.Windows;
using System.Windows.Input;

namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for EventsSample.xaml
    /// </summary>
    public partial class EventsSample : Window
    {
        public EventsSample()
        {
            InitializeComponent();
            pnlMainGrid.MouseUp += new MouseButtonEventHandler(pnlMainGrid_MouseUp);
            pnlMainGrid.MouseDown += new MouseButtonEventHandler(pnlMainGrid_MouseDown);
        }

        private void pnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("You started a click at " + e.GetPosition(this).ToString());
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }
    }
}
