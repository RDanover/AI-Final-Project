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
//TO DO: send operation choice to back end
namespace Integrative_Systems_Solution
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Load_Unload_Click(object sender, RoutedEventArgs e)
        {
            //tell backend we are doing a load operation and know to load the corresponding pages 
            //set global variable
            
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.DumbGlobalVariable.Text = "LUL";
            mainwindow.mainFrame.Navigate( new Upload_Manifest());

        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {
            //tell backend we are doing a balance operation and know to load corresponding pages 
            //set global variable
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.DumbGlobalVariable.Text = "B";
            mainwindow.mainFrame.Navigate(new Upload_Manifest());
        }
    }
}
