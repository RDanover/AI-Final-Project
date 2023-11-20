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
// TO DO: get step # and move # from backend, potentially remove calculating page and instead hide and unhide elements on this page
namespace Integrative_Systems_Solution
{

    public partial class X_moves_in_X_minutes : Page
    {
        public X_moves_in_X_minutes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new Step_X_of_X());
        }
    }
}
