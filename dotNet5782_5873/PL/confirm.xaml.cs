using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for confirm.xaml
    /// </summary>
    public partial class confirm : Window
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        BO.Cart cart;

        public confirm(Cart cart)
            
        {
            
            InitializeComponent();
            ListProductConfirm.ItemsSource = bl.Cart.GetAll(cart);
            //ListUserConfirm.ItemsSource= 
            TotalPriceLabel.Content = cart.TotalPrice.ToString() + "$";
            name.Content = cart.CustomerName;
            Adress.Content = cart.CustomerAddress;
            Mail.Content = cart.CustomerEmail;
          
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            new MyCart(cart).Show();
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            new NewCart().Show();   
        }

        private void ListView_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
