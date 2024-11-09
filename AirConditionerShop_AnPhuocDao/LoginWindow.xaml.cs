using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
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
        private UserService _userService = new();
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and password is required", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            StaffMember? account = _userService.Authenticate(email, password);
            if (account == null)
            {
                MessageBox.Show("Email or password is incorrect", "Invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (account.Role == 3)
            {
                MessageBox.Show("You do not have permission", "Can't access", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MainWindow mainWindow = new();
            mainWindow.loginUser = account;
            mainWindow.Show();
            this.Hide();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageResult = MessageBox.Show("Do you want to exit", "Exit!", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (messageResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
