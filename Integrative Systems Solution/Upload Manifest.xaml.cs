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
//TO DO: alot, implement ability for user to open file explorer, sent file or file location to backend,
//using filename update manifest name in top corner
namespace Integrative_Systems_Solution
{
    /// <summary>
    /// Interaction logic for Upload_Manifest.xaml
    /// </summary>
    public partial class Upload_Manifest : Page
    {
        public Upload_Manifest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //pass manifest path to backend

            //Check which operation were doing before moving to the next page
            
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;

            //balance
            if(mainwindow.DumbGlobalVariable.Text == "B")
            {
                mainwindow.mainFrame.Navigate(new Calculating());
            }
            

            //load
            if(mainwindow.DumbGlobalVariable.Text == "LUL")
            {
                mainwindow.mainFrame.Navigate(new Unload_Select());
            }
            
        }
    }
}
