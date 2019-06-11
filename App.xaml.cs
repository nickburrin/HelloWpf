using System.Windows;
using HelloWpf.basic_controls;
using HelloWpf.commands;
using HelloWpf.common_interface_controls;
using HelloWpf.control_concepts;
using HelloWpf.data_binding;
using HelloWpf.panels;
using HelloWpf.user_controls;

namespace HelloWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the startup window
            MenuWithCommandsSample wnd = new MenuWithCommandsSample();
            
            // Do stuff here, e.g. to the window
            wnd.Show();
        }

        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }
}
