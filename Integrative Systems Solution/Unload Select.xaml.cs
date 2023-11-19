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
//TO DO: alot, implement ability to select mulitple containers using check boxes and display to user, scroll bar for these displayed conatiners (maybe),
// send and recieve all container to back end using a data structure (undecided which yet)
namespace Integrative_Systems_Solution
{
    /// <summary>
    /// Interaction logic for Unload_Select.xaml
    /// </summary>
    public partial class Unload_Select : Page
    {
        public Unload_Select()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new Load_Select());
        }
    }
}
