using System;
using System.Collections.Generic;
using System.Configuration;
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
//TO DO:  Send note to back end, send user name to back end, check if input is valid
namespace Integrative_Systems_Solution
{

    public partial class MainWindow : Window
    {
        //Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public MainWindow()
        {
            InitializeComponent();

            /*if(AppConfig.Sections["RecoveryData"] is null)
            {
                //starting the program for the first time 
                AppConfig.Sections.Add("RecoveryData",new RecoveryData());
                var RecoveryDataSection = AppConfig.GetSection("RecoveryData");
                //create new instance of an operation
                //IntPtr operation = new operation();
                //RecoveryDataSection.CurrentOperation = operation;

                //save changes: needs to be done any time we have changed an element of the operation

                //ConfigurationManager.RefreshSection("RecoveryData");
                //AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //AppConfig.Save(ConfigurationSaveMode.Modified);

                mainFrame.Navigate(new Main());
            }
            else
            {
                var RecoveryDataSection = AppConfig.GetSection("RecoveryData");
                //IntPtr operation = RecoveryDataSection.CurrentOperation;
                //int page = RecoveryDataSection.CurrentPage;
                //navigate to correct page based off page #,
                //0 main
                //1 upload manifest
                //2 Unload Select
                //3 Load Select
                //4 X moves X minutes
                //5 step x of x
                //6 download manifest
            }*/

            mainFrame.Navigate(new Main());
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            usernameInput.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            usernoteInput.Visibility = Visibility.Visible;
        }

        private void UsernameInput_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                string userinputname = usernameInput.Text;
                UserNameDisplay.Text = userinputname;
                usernameInput.Visibility = Visibility.Hidden;
                //pass user name to back end 
                usernameInput.Text = "";
            }

        }

        private void UsernoteInput_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                usernoteInput.Visibility = Visibility.Hidden;
                //pass note info to back end
                usernoteInput.Text = "";
            }
            
        }
    }
}
