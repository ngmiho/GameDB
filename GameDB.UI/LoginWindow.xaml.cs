using GameDB.BLL.Services;
using System.Windows;

namespace GameDB.UI
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

        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            StaffMemberService _service = new();

            if (_service.getStaffMember(TxtEmailAdress.Text, TxtPassword.Password.ToString()) != null)
            {
                this.Hide();
                new MainWindow().Show();
            }
            else
                MessageBox.Show("False");

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
