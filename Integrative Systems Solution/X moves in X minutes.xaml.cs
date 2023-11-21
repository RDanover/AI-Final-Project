using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
// TO DO: get step # and move # from backend
namespace Integrative_Systems_Solution
{

    public partial class X_moves_in_X_minutes : Page
    {
        public X_moves_in_X_minutes()
        {
            InitializeComponent();
            Loaded += Page_Loaded;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TextDisplay.Text = "Calculating . . .";
            Confirm.Visibility = Visibility.Hidden;
            await Task.Run(()=>
            {
                System.Threading.Thread.Sleep(3000);// for demo purpose only simulates time for processing
            });
            TextDisplay.Text = "This Operation will take "+ "X"+ " moves and will take "+ "X"+" minutes.";
            Confirm.Visibility = Visibility.Visible;
            Loaded -= Page_Loaded;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new Step_X_of_X());
        }
    }
}
