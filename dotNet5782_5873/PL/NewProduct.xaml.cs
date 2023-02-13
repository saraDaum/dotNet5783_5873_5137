using BlApi;
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
    /// Interaction logic for NewProduct.xaml
    /// </summary>
    public partial class NewProduct : Window
    {
        IBl bl = new BlImplementation.BL();
        public NewProduct()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextAdd(object sender, TextChangedEventArgs e)
        {

        }
        //הפונקציה שקוראת כשלוחצים אישור על הוספת הפריט
        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //Check that fields doesn't empty 
            if (Nametxb.Text != "" || Pricetxb.Text != null || Amounttxb.Text != null || CategoryTxb.Text != null)//null or ""
            {
                //We create a new instance of Product with this details.
                BO.Product product = new BO.Product();
                product.ProductName = Nametxb.Text;
                product.ProductPrice = int.Parse(Pricetxb.Text);
                product.AmountInStock = int.Parse(Amounttxb.Text);
                product.Category = (DO.Category)Enum.Parse(typeof(DO.Category), CategoryTxb.Text);
                //Add product to list
                try
                {
                   int i= bl.Product.Add(product);
                    // מה יקרה עכשיו: החלון יסגר ויחזור לתצוגה הראשית או הודעה או כל דבר אחר...
                }
                catch
                {
                    //מה עושים כשתופסים שגיאה?
                    //אפשר לספר למשתמש על התקלה או מה שבא לנו אם לא מה שעושה ה"קטץ" זה שהתוכנית תמשיך לרוץ
                }
                
            }
        }
    }
}
