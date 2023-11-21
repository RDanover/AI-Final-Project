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
//TO DO: 
//check if the weight is given if not get from user, check for correct input, animation for container movement 
namespace Integrative_Systems_Solution
{

    public partial class Step_X_of_X : Page
    {
        //get moves and current index from X_Moves_in_X_minutes
        public Step_X_of_X()
        {
            InitializeComponent();
            //using current index and moves change text
            StepDisplay.Text = "Step " + "X" + " of " + "X"+":";
            StepDetailsDisplay.Text = "Move " + "X" + " from " + "X" + " to " + "X"+"\n";
            StepDetailsDisplay.Text += "Time for this move: " + "X" + " min\n";
            StepDetailsDisplay.Text += "Time remaining: " + "X" + " min\n";
            //if weight != -1
            //StepDetailsDisplay.Text += "Weight: " + "X" + " kilos";Commented out for sake of demo
            //if weight ==-1
            Weight_Input.Visibility = Visibility.Visible;
            weightprompt.Visibility = Visibility.Visible;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            //tell backedn we completed index i
            //if not done
            //for demo purposes commented out 
            //mainwindow.mainFrame.Navigate(new Step_X_of_X());

            //if done
            
            mainwindow.mainFrame.Navigate(new Download_Manifest());
        }

        private void WeightInput_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string userinputweight = Weight_Input.Text;
                Weight_Input.Visibility = Visibility.Hidden;
                weightprompt.Visibility = Visibility.Hidden;
                StepDetailsDisplay.Text += "Weight: " + userinputweight + " kilos";
                //pass user name to back end
                Weight_Input.Text = "";
            }

        }
    }
}
