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
    /// Interaction logic for LoginViewBasic.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        string userid = "admin";
        string password = "admin";

        public LoginView()
        {
            InitializeComponent();
        }

        private void login_click(object sender, RoutedEventArgs e)
        {
            //HomeView view = new HomeView();
            //view.Show();

            HomeViewUI similar = new HomeViewUI();
            similar.Show();

            //HomeViewTabular homeViewTabular = new HomeViewTabular();
            //homeViewTabular.Show();

            this.Close();
        }
    }
}