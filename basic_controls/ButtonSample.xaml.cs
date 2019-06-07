using System.Windows;

namespace HelloWpf.basic_controls
{
    /// <summary>
    /// Interaction logic for ButtonSample.xaml
    /// </summary>
    public partial class ButtonSample : Window
    {
        public ButtonSample()
        {
            InitializeComponent();
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, world!");
        }
    }
}
