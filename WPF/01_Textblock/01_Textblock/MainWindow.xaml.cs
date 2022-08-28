using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace _01_Textblock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += Window_Loaded;
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock txtbl = sender as TextBlock;
            txtbl.Text = "Free Education";
        }
        private void TextBlock_MouseEnter_link(object sender, MouseEventArgs e)
        {
            TextBlock txtbl = sender as TextBlock;
            txtbl1.Text = "www.HowKteam.com";
        }

        private void TextBlock_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //System.Diagnostics.Process.Start("cmd","/c start http://www.google.com");
            Process.Start("cmd", "/c start http://www.howkteam.com");
            //Process.Start(new ProcessStartInfo(e.Uri.ToString()));
            //e.Handled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtbl2.Text = txtbl1.Text;
        }

        private void txtbl1_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtbl2.Text = txtbl1.Text;
            this.Loaded += Window_Loaded;
        }
    }
}
