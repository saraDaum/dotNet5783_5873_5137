using BlApi;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PL.Product
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        IBl? bl;
        public ListView(IBl? bl)
        {
            this.bl = bl;
            InitializeComponent();
            Selector.ItemsSource = Enum.GetValues(typeof(DO.Category));
            ProductListview.ItemsSource = bl.Product.Get(item => item.Barcode == item.Barcode);


        }

        private void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IEnumerable<Category>? selctorsItems = new List<Category>();
            var category = Selector.SelectedItem;
            Selector.SelectedItem = bl.Product.Get(item => item.Category == (Category)category);


        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
