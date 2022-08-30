using System;
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

namespace _02_Button
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // cach khac de them 1 buttton
            //Button btn = new Button();
            //GridButton.Children.Add(btn);
            //String msg = "Say Hi !!!"
            //btn.Width = 20;
            //btn.Height = 20;    
            //btn.Content = msg;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Say Hi !!! Im" + "\n" + "I'm Rikkei member");
        }
    }
}
