using GameDB.BLL.Services;
using GameDB.DAL.Entities;
using System.Windows;

namespace GameDB.UI
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        public AirConditioner airConditioner { get; set; }
        public bool isUpdate { get; set; } = false;
        public DetailWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            airConditioner.AirConditionerName = TxtAirConditionerName.Text;
            airConditioner.Warranty = TxtWarranty.Text;
            airConditioner.SoundPressureLevel = TxtSoundPressureLevel.Text;
            airConditioner.FeatureFunction = TxtFeatureFunction.Text;
            airConditioner.Quantity = int.Parse(TxtQuantity.Text);
            airConditioner.DollarPrice = float.Parse(TxtDollarPrice.Text);

            AirConditionerService airConditionerService = new AirConditionerService();
            if (isUpdate == false)
            {
                airConditionerService.AddAirCon(airConditioner);
            }
            else
                airConditionerService.UpdateAirCon(airConditioner);

            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (airConditioner == null)
                return;
            TxtAirConditionerName.Text = airConditioner.AirConditionerName;
            TxtWarranty.Text = airConditioner.Warranty;
            TxtSoundPressureLevel.Text = airConditioner.SoundPressureLevel;
            TxtFeatureFunction.Text = airConditioner.FeatureFunction;
            TxtQuantity.Text = airConditioner.Quantity.ToString();
            TxtDollarPrice.Text = airConditioner.DollarPrice.ToString();
        }
    }
}
