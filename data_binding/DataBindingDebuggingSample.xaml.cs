using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Data;

namespace HelloWpf.data_binding
{
    /// <summary>
    /// Interaction logic for DataBindingDebuggingSample.xaml
    /// </summary>
    public partial class DataBindingDebuggingSample : Window
    {
        public DataBindingDebuggingSample()
        {
            InitializeComponent();
        }
    }

    public class DebugDummyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Debugger.Break();
            return value;
        }
    }
}
