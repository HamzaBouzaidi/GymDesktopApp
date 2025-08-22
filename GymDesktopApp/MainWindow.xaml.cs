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

namespace GymDesktopApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Register();
        }
        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Signin();
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Register();
        }

    }
}