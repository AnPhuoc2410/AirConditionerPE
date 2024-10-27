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

namespace AirConditionerShop_AnPhuocDao
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = EmailTextBox.Text;
            string password = PasswordBox.Password;

            bool loginSucces = CheckingLogin(username, password);
            if (loginSucces)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Wrong email or password");
            }
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageResult = MessageBox.Show("Do you want to exit", "Exit!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (messageResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
        private Boolean CheckingLogin(string username, string password)
        {
            List<String> userLogin = ["admin", "Jaden", "sheme"];
            foreach (var name in userLogin)
            {
                if (name.Equals(username)) return true;
            }
            return false;
        }
    }
}
