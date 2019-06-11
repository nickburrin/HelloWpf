using System.Windows;
using System.Windows.Input;

namespace HelloWpf.commands
{
    /// <summary>
    /// Interaction logic for UsingCommandsSample.xaml
    /// </summary>
    public partial class UsingCommandsSample : Window
    {
        public UsingCommandsSample()
        {
            InitializeComponent();
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The New command was invoked");
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
