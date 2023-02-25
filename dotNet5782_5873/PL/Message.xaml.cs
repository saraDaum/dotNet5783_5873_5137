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
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : Window
    {
        public Message(string message, string type)
        {

            InitializeComponent();
            Text.Content = message;
            switch (type)
            {
                case "alert":
                    Text.Background = Brushes.Red;
                    break;
                case "info":
                    Text.Background = Brushes.Green;
                    break;

                default:
                    break;
            }
        }

        internal static void ShowDialog(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
