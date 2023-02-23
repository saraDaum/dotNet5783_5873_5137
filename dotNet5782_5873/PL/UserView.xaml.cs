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
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window

    {
        BlApi.IBl bl = BlApi.Factory.Get();

        public UserView()
        {
            InitializeComponent();

            ListProductUser.ItemsSource = bl.ProductItem.Get(e=>e.GetHashCode()==e.GetHashCode());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
