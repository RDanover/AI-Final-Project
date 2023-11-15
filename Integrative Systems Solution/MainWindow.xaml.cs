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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Main());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            usernameInput.Visibility = Visibility.Visible;
            //get user name, and send to back end, display to user
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            usernoteInput.Visibility = Visibility.Visible;
            
            //get a note from user, and send to back end, dont need to display anything
        }

        private void UsernameInput_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                string userinputname = usernameInput.Text;
                UserNameDisplay.Text = userinputname;
                usernameInput.Visibility = Visibility.Hidden;
                usernameInput.Text = "";
            }

        }

        private void UsernoteInput_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                usernoteInput.Visibility = Visibility.Hidden;
            }
            
        }
    }
}
