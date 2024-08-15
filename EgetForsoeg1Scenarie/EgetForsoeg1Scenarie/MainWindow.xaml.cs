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

namespace EgetForsoeg1Scenarie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new Forside();
        }

        private void BtnClickNyFilm(object sender, RoutedEventArgs e)
        {
            Main.Content = new NyFilm();
        }

        private void BtnClickForside(object sender, RoutedEventArgs e)
        {
            Main.Content = new Forside();
        }
    }
}