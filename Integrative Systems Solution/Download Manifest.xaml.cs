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
//TO DO: get file location from backend, display file location to user
namespace Integrative_Systems_Solution
{
    public partial class Download_Manifest : Page
    {
        public Download_Manifest()
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            InitializeComponent();
            Display_Location.Text = mainwindow.ManifestNameDisplay.Text+"_OUTBOUND has been written to: X. Please send to Captain";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //reset global variables
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.GlobalVariable.Text = "N";
            mainwindow.ManifestNameDisplay.Text = " ";
            mainwindow.mainFrame.Navigate(new Main());
        }
    }
}
