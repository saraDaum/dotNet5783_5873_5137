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
    /// Interaction logic for ItemInCart.xaml
    /// </summary>
    public partial class ItemInCart : Window
    {
        private Cart cart;
        BO.ProductItem ProductItem;
        BlApi.IBl bl = BlApi.Factory.Get();

        public ItemInCart(Cart cart , BO.ProductItem productItem)
        {
            this.cart = cart;
            ProductItem = productItem;
            InitializeComponent();
            DataLabel.Content = productItem.ToString();
        }

        private void ChangeAmountButton_Click(object sender, RoutedEventArgs e)
        {
            if (AmountTxtbx.Text != "")
            {
                try
                {
                    bl.Cart.ChangeAmount(cart, ProductItem.Barcode, int.Parse(AmountTxtbx.Text));
                    new MyCart(cart).Show();
                    Close();
                }
                catch { }
            }
        }

      
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                bl.Cart.Delete(cart, ProductItem);
                new MyCart(cart).Show();
                Close();
            }
            catch { }
        }
    }
}
