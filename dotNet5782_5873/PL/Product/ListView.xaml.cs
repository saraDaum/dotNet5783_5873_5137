using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.Product
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        IBl? bl = BlApi.Factory.Get();
        BO.Cart cart;

        //A private list with all Filters products
        private IEnumerable<BO.Product>? FiltersProduct = new List<BO.Product>();//I think taht we can delete it

        public ListView(IBl? bl, Cart? cart= null)
        {
            if(cart != null)
            {

            }
            try
            {
                this.bl = bl;
                InitializeComponent();
                Selector.ItemsSource = Enum.GetValues(typeof(DO.Category));
                //To show all without filter
                var category = Selector.SelectedItem;
                if (category != null)
                    ProductListview.ItemsSource = bl.Product.Get(item => (int)item.Category == (int)category);
                else
                    ProductListview.ItemsSource = bl.Product.Get(item => item.Barcode == item.Barcode);//Stopid condition- to get all items.
            }
          
            catch (somethingWrong ex)
            {

               /* myMessagesWindow wnd = new myMessagesWindow(ex.innerexception.messages);
                wnd.ShowDialog();*/
            }
            catch (Exception)
            {

               /* lbl1.text = "kjhgfgf";
                myMessagesWindow wnd = new myMessagesWindow(ex.innerexception.messages);
                wnd.ShowDialog();*/
            }        }

        //public ListView(IBl bl)
        //{
        //    this.bl = bl;
        //    InitializeComponent();
        //    Selector.ItemsSource = Enum.GetValues(typeof(DO.Category));
        //}

        public void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = Selector.SelectedItem;
            if (category != null)
                ProductListview.ItemsSource = bl.Product.Get(item => (int)item.Category == (int)category);
            else//If he didn't choose any condition to filter we return all items
                ProductListview.ItemsSource = bl.Product.Get(item => item.Barcode == item.Barcode);//Stopid condition- to get all items.
            return;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new NewProduct(cart).Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductListview.ItemsSource = bl.Product.Get(item => item.Category == item.Category);//To get all.
        }

        private void choosen(object sender, MouseButtonEventArgs e)
        {
            BO.Product product = (BO.Product)ProductListview.SelectedItem;
            new NewProduct(product).Show();
        }
    }
}
