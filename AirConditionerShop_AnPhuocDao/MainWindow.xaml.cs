using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirConditionerShop_AnPhuocDao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AirConditionerService _service = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            AirCondDataGrid.ItemsSource = null;//Clear grid
            AirCondDataGrid.ItemsSource = _service.GetAllAirConditioner();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow detailWindow = new DetailWindow();
            detailWindow.ShowDialog();
            FillDataGrid();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner? selected = AirCondDataGrid.SelectedItem as AirConditioner;
            if (selected is null)
            {
                MessageBox.Show("PLease select an air-conditioner before udpating", "Select one", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DetailWindow detailWindow = new();
            detailWindow.DataTranfer = selected;
            detailWindow.ShowDialog();
            FillDataGrid();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner? selected = AirCondDataGrid.SelectedItem as AirConditioner;
            if (selected is null)
            {
                MessageBox.Show("Please select an air-conditioner before deleting", "Select one", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MessageBoxResult result = MessageBox.Show("Do you want to delete ?","Delete Air Conditioner ?",MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                return;
            }
            _service.DeleteAirConditioner(selected);
            FillDataGrid();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}