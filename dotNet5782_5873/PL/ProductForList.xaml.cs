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
    /// Interaction logic for ProductForList.xaml
    /// </summary>
    public partial class ProductForList : Window
    {
        BlApi.IBl bl = BlApi.Factory.Get();
        public ProductForList()
        {
            InitializeComponent();
            product.ItemsSource = bl.Product.Get(e=>e.GetHashCode()==e.GetHashCode());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new NewProduct().Show();
        }

        private void product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
