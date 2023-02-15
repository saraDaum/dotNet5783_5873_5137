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
        
        BlApi.IBl bl  = BlApi.Factory.Get();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new PL.Product.ListView(bl).Show();
        }

       
    }
}
