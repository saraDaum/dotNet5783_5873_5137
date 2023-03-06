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
    /// Interaction logic for PayDetails.xaml
    /// </summary>
    public partial class PayDetails : Window
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        BO.Cart cart;
        BO.Order newOrder;
        int flag = 0;
        IEnumerable<BO.Product> allProducts;
        public PayDetails(BO.Cart UserCart)
        {
            cart = UserCart;
            InitializeComponent();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Digits != null && CreditDate != null && CreditNumber != null)//What happend???
            {  
                allProducts = bl.Product.Get(item => item.Barcode == item.Barcode);
                foreach (BO.ProductItem item in cart.ItemsInCart)
                {
                    BO.Product productToUpdate = allProducts.First(product => product.Barcode == item.Barcode);
                    if (productToUpdate.AmountInStock >= item.Amount)
                    {
                        productToUpdate.AmountInStock -= item.Amount;//ZERO?? TO DO

                    }
                    else
                    {
                        if (flag == 0)
                            new Message("We are sorry, but the requested quantity of" +item.Name + "is not in stock", "alert").Show();
                        this.Close();
                        
                        flag++;

                    }

                }

            }
        }
    }
}
