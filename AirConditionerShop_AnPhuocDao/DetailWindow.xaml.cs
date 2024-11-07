using AirConditionerShop.BLL.Services;
using AirConditionerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        AirConditionerService _airService = new();
        SupplierService _supplierService = new();

        public AirConditioner DataTranfer { get; set; }
        public DetailWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillComboBox();
            FillValue();
        }

        private void FillComboBox()
        {
            SupplierIdComboBox.ItemsSource = _supplierService.GetAllSupplier();
            SupplierIdComboBox.DisplayMemberPath = "SupplierName";
            SupplierIdComboBox.SelectedValuePath = "SupplierId";
        }
        private void FillValue()
        {
            if (DataTranfer == null)
            {
                DetailWindowMode.Content = "Create a new Air Conditioner";
                return;
            }
            DetailWindowMode.Content = "Edit Air Conditioner";
            AirConditionerIdTextBox.IsEnabled = false;

            AirConditionerIdTextBox.Text = DataTranfer.AirConditionerId.ToString();
            AirConditionerNameTextBox.Text = DataTranfer.AirConditionerName;
            WarrantyTextBox.Text = DataTranfer.Warranty;
            SoundPressureLevelTextBox.Text = DataTranfer.SoundPressureLevel;
            FeatureFunctionTextBox.Text = DataTranfer.FeatureFunction;
            QuantityTextBox.Text = DataTranfer.Quantity.ToString();
            DollarPriceTextBox.Text = DataTranfer.DollarPrice.ToString();
            SupplierIdComboBox.SelectedValue = DataTranfer.SupplierId;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckVar()) return;
            AirConditioner obj = new();
            obj.AirConditionerId = int.Parse(AirConditionerIdTextBox.Text);
            obj.AirConditionerName = AirConditionerNameTextBox.Text;
            obj.Warranty = WarrantyTextBox.Text;
            obj.SoundPressureLevel = SoundPressureLevelTextBox.Text;
            obj.FeatureFunction = FeatureFunctionTextBox.Text;
            obj.Quantity = int.Parse(QuantityTextBox.Text);
            obj.DollarPrice = Double.Parse(DollarPriceTextBox.Text);
            obj.SupplierId = SupplierIdComboBox.SelectedValue.ToString();
            if (DataTranfer == null)
            {
                _airService.AddAirConditioner(obj);
            }
            else
            {
                _airService.UpdateAirConditioner(obj);
            }
            this.Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private bool CheckVar()
        {
            if (string.IsNullOrWhiteSpace(AirConditionerNameTextBox.Text))
            {
                MessageBox.Show("Air-name is required", "Field Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (AirConditionerNameTextBox.Text.Trim().Length < 5)
            {
                MessageBox.Show("Air-name is must be >= 5", "Length Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string airConsName = AirConditionerNameTextBox.Text.Trim();
            AirConditionerNameTextBox.Text = textInfo.ToTitleCase(airConsName.ToLower());

            bool convertedStatus = int.TryParse(QuantityTextBox.Text, out int quantity);
            if (!convertedStatus)
            {
                MessageBox.Show("Quantity is a number", "Quantity Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if(quantity < 0 || quantity > 100)
            {
                MessageBox.Show("Quantity is Positive or Less than 100", "Quantity Required", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            return true;
        }
    }
}
