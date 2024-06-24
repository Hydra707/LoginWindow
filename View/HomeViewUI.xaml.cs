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
using System.Windows.Shapes;

namespace LoginWindow.View
{
    /// <summary>
    /// Interaction logic for HomeViewUI.xaml
    /// </summary>
    public partial class HomeViewUI : Window
    {
        public HomeViewUI()
        {
            InitializeComponent();
        }

        private void template_click(object sender, RoutedEventArgs e)
        {
            if (sender != null)
            {
                Button btn = sender as Button;
                DemoPage demo = new DemoPage();
                demo.Display((string)btn.Content);
            }
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, you want to Exit ?", "Confirm", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void help_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I will be helpfull to you", "Help");
        }

        private void zip_changed(object sender, TextChangedEventArgs e)
        {
            TextBox txtbox = sender as TextBox;
            if (txtbox.Text.Length == 3)
            {
                txtbox_gp.Text = "26";
                txtbox_sp.Text = "26";
            }
            else
            {
                txtbox_gp.Text = "";
                txtbox_sp.Text = "";
            }
        }
    }
}