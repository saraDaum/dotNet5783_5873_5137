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
    /// Interaction logic for NewCart.xaml
    /// </summary>
    public partial class NewCart : Window
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        public NewCart()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool flag = true;
            if (NameTxt.Text != "" && EmailTxt.Text != "" && AddressTxt.Text != "")
            {
                BO.Cart cart = new BO.Cart();
                cart.CustomerName = NameTxt.Text;
                if (EmailTxt.Text.Contains("@gmail.com"))
                {
                    cart.CustomerEmail = EmailTxt.Text;

                }
                else
                {
                    MessageBox.Show("Please enter valid email address", "Error");
                    flag = false;
                }
                cart.CustomerAddress = AddressTxt.Text;
                if (flag)
                {
                    new UserView(cart).Show();
                    Close();
                }
            }
            else
                MessageBox.Show("Some details seem to be missing", "Error");


        }

        private void AddressTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
