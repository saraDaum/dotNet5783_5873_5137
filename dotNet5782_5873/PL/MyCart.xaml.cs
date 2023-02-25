using AutoMapper.Configuration.Annotations;
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
    /// Interaction logic for MyCart.xaml
    /// </summary>
    public partial class MyCart : Window
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        BO.Cart cart;
        public MyCart(BO.Cart cart)
        {
            this.cart = cart;
            InitializeComponent();
            CartList.ItemsSource = bl.Cart.GetAll(cart);
            TotalPriceLabel.Content = cart.TotalPrice.ToString() + "$";
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new UserView(cart).Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            new ItemInCart(cart, (BO.ProductItem)CartList.SelectedItem).Show();
            Close();
        }
    }
}
