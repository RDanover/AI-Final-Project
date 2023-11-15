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

namespace Integrative_Systems_Solution
{
    /// <summary>
    /// Interaction logic for Calculating.xaml
    /// </summary>
    public partial class Calculating : Page
    {
        public Calculating()
        {
            InitializeComponent();
            //stay on this page until the backend says to proceed
            //figure out how to implement without user input
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new X_moves_in_X_minutes());
        }
    }
}
