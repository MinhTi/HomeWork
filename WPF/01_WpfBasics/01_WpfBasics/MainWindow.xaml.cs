﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.DescriptionText.Text }");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.RollCheckbox.IsChecked
                = this.FoldCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.PurchareCheckbox.IsChecked
                = this.LaserCheckbox.IsChecked = this.SawCheckbox.IsChecked = this.LatherCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content + $" ";
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;
            var combobox = (ComboBox)sender;
            var value = (ComboBoxItem)combobox.SelectedValue;

            this.NoteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropdown, null);
        }
    }
}