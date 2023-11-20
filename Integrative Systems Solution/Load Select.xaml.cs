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
//TO DO: check input for valid input, send all container to back end using a data structure (undecided which yet)
namespace Integrative_Systems_Solution
{

    public partial class Load_Select : Page
    {
        public Load_Select()
        {
            InitializeComponent();
        }
        private void ContainerInput_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string userinputcontainer = ContainerInput.Text;
                ContainersList.Text += userinputcontainer +"\n";
                ContainerInput.Text = "";
                //create new container and add it to the list
            }
        }

            private void Button_Click(object sender, RoutedEventArgs e)
        {
            //send list of containers to backend
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new X_moves_in_X_minutes());
        }
    }
}
