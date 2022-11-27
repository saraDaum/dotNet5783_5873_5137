using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class OrderItem
    {
        public int ProductID { get;}
        public int OrderID { get;}
        public double ProductPrice { get;}
        public int Amount { get;}
        public int autoID { get;}

        public override string ToString() => $@"
    Order item details:\n
    ID code: {autoID}
    Product barkode: {ProductID}, 
    Order number: {OrderID}, 
    Price: {ProductPrice},
   	Amount in order: {Amount}";
    }
}
