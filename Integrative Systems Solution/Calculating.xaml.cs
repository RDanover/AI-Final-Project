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
//TO DO: ask backend before moving to X moves in X minutes, potentially remove this page and instead hide and unhide elements on x moves in x minutes page
namespace Integrative_Systems_Solution
{

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
