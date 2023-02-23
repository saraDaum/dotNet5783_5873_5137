using System.Windows;
using PL.Product;
using System.Windows.Controls;


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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {   //לפתוח חלון שמותר רק למנהל
                
            uc.Visibility = Visibility.Visible;
            if  (Authentication.IsManager)
                new Manager().Show();    
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
