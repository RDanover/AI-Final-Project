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
//TO DO: recieve all containers from back end, send selected containers to backend
namespace Integrative_Systems_Solution
{

    public partial class Unload_Select : Page
    {
        private List<string> options = new List<string> {"Container 1","Container 2","Container 3" };
        private List<int> selected = new List<int>();

        public Unload_Select()
        {
            InitializeComponent();
            //get list of containers from back end
            StackPanel stackPanel = new StackPanel();
            ContainerViewer.Content = stackPanel;
            CreateCheckBoxes(stackPanel);//create new textboxes with content from containers from backend
        }
        private void CreateCheckBoxes(StackPanel stackPanel)
        {
            int i = 1;
            foreach (string option in options)
            {
                CheckBox checkBox = new CheckBox
                {
                    Content = option,
                    Margin = new Thickness(5),
                    VerticalAlignment = VerticalAlignment.Top,
                    FontFamily = new FontFamily("Arial"),
                    FontSize = 24
                    

                };
                checkBox.Tag = i;
                i++;

                checkBox.Checked += CheckBox_Checked;
                checkBox.Unchecked += CheckBox_UnChecked;

                stackPanel.Children.Add(checkBox);
            }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is CheckBox checkbox && checkbox.Tag is int index)
            {
                selected.Add(index);

            }
        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox checkbox && checkbox.Tag is int index)
            {
                selected.Remove(index);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (int index in selected)
            {
                //use indecies to send containers to be unloaded to back end
            }
            MainWindow mainwindow = (MainWindow)Application.Current.MainWindow;
            mainwindow.mainFrame.Navigate(new Load_Select());
        }

    }
}
