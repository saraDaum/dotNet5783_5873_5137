using BlApi;
using System.Windows;
using PL.Product;
using System.Windows.Controls;
using PL.Product;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBl bl = new BlImplementation.BL();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ListView(bl).Show();
        }

        private void _try_Click(object sender, RoutedEventArgs e)
        {
            BO.Product p = new BO.Product();
            new NewProduct(p).Show();
        }
    }
}
