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
    /// Interaction logic for Step_X_of_X.xaml
    /// </summary>
    public partial class Step_X_of_X : Page
    {
        public Step_X_of_X()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            
            //if not done
            //for demo purposes commented out 
            //mainwindow.mainFrame.Navigate(new Step_X_of_X());

            //if done

            mainwindow.mainFrame.Navigate(new Download_Manifest());
        }
    }
}
