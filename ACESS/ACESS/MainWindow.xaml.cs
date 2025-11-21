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


namespace ACESS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtUser.Text == "tutor" && txtPass.Password == "123")
            {
                
                DashboardWindow dash = new DashboardWindow();
                dash.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.\nTente: tutor / 123", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}