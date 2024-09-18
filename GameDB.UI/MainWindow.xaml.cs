using GameDB.BLL.Services;
using GameDB.DAL.Entities;
using System.Windows;

namespace GameDB.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AirConditionerService _service = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            MainDataGrid.ItemsSource = _service.getAllAirConditioners();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner airConditioner = new AirConditioner();

            DetailWindow detail = new DetailWindow();
            detail.airConditioner = airConditioner;
            detail.ShowDialog();

            FillData();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            AirConditioner? selected = MainDataGrid.SelectedItem as AirConditioner;

            if (selected == null)
                MessageBox.Show("Let's choose a product first");
            else
            {
                DetailWindow detail = new DetailWindow();
                detail.airConditioner = selected;
                detail.isUpdate = true;
                detail.ShowDialog();

                FillData();
            }

        }

        private void BtnSearching_Click(object sender, RoutedEventArgs e)
        {
            if (TxtSearching.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Let's input name for searching air conditioner");
                MainDataGrid.ItemsSource = null;
                MainDataGrid.ItemsSource = _service.getAllAirConditioners();
            }
            else
            {
                MainDataGrid.ItemsSource = null;
                MainDataGrid.ItemsSource = _service.getAirConditionersByName(TxtSearching.Text);
            }
        }

        private void FillData()
        {
            MainDataGrid.ItemsSource = null;
            MainDataGrid.ItemsSource = _service.getAllAirConditioners();
        }
    }
}