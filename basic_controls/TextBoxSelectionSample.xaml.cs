﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace HelloWpf.basic_controls
{
    /// <summary>
    /// Interaction logic for TextBoxSelectionSample.xaml
    /// </summary>
    public partial class TextBoxSelectionSample : Window
    {
        public TextBoxSelectionSample()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }
    }
}
