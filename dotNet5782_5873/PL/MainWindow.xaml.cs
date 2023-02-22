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
           
                            new NewCart().Show();
//לפתוח חלון שמותר רק למנהל
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uc.Visibility = Visibility.Visible;
            if  (Authentication.IsManager)
                new Manager().Show();    
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
