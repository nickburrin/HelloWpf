﻿using System.Windows;
using System.Windows.Media;

namespace HelloWpf.misc_controls
{
    /// <summary>
    /// Interaction logic for SliderValueChangedSample.xaml
    /// </summary>
    public partial class SliderValueChangedSample : Window
    {
        public SliderValueChangedSample()
        {
            InitializeComponent();
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            this.Background = new SolidColorBrush(color);
        }
    }
}
