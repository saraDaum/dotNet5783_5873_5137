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

        //A private list with all Filters products
        private IEnumerable<BO.Product>? FiltersProduct = new List<BO.Product>();

        public ListView(IBl? bl)
        {
            this.bl = bl;
            InitializeComponent();
            Selector.ItemsSource = Enum.GetValues(typeof(DO.Category));
            var category = Selector.SelectedItem;
            if (category != null)
                ProductListview.ItemsSource = bl.Product.Get(item => item.Category == (Category)category);
            else//If he didn't choose any condition to filter we return all items
                ProductListview.ItemsSource = bl.Product.Get(item => item.Category == item.Category);//Stopid condition- to get all items.
        }
       
        private void Selector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*  var category = Selector.SelectedItem;
               if(category!=null)
                  FiltersProduct = bl.Product.Get(item => item.Category == (Category)category);
               else//If he didn't choose any condition to filter we return all items
                   FiltersProduct = bl.Product.Get(item => item.Category == item.Category);//Stopid condition- to get all items.*/
            var category = Selector.SelectedItem;
            if (category != null)
                ProductListview.ItemsSource = bl.Product.Get(item => item.Category == (Category)category);
            else//If he didn't choose any condition to filter we return all items
                ProductListview.ItemsSource = bl.Product.Get(item => item.Category == item.Category);//Stopid condition- to get all items.
            return;

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*foreach (BO.Product in FiltersProduct)
            {
                Button newBtn = new Button();
                Image buttonImage = new Image();
                buttonImage.Width = 100;
                buttonImage.Height = 100;
                buttonImage.Stretch = Systems.Windows.Media.Stretch.Uniform;
                buttonImage.Source = new BitmapImage(pokemon.ImageURI);
                newBtn.Tag = item.Id;
                newBtn.Name = String.Format("{0}Button", item.Name);
                newBtn.Click += new RoutedEventHandler(newBtn_Click);

                FamilyStackPanel.Children.Add(newBtn);
            }*/
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new NewProduct().Show();
        }
    }
}
