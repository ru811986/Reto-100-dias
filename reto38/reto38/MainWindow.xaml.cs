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

namespace reto38
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombre.Text.Trim().Length > 0)
            {
                lblSaludo.Content = $"Bienvenid@ {txtNombre.Text.Trim()}";
                txtNombre.Text = "";
            }
            else
            {
                lblSaludo.Content = "Bienvenid@";
            }
        }
    }
}