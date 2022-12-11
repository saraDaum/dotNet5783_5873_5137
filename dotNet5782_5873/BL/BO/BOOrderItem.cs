using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class BOOrderItem
    {
        /// <summary>
        /// Product barcde in OrderItem
        /// </summary>
        public int ProductID { get;}

        /// <summary>
        /// Order number in OrderItem
        /// </summary>
        public int OrderID { get;}

        /// <summary>
        /// Product price in OrderItem
        /// </summary>
        public double ProductPrice { get;}

        /// <summary>
        /// The requested quantity of the product
        /// </summary>
        public int Amount { get;}

        /// <summary>
        /// Auto ID for this OrderItem
        /// </summary>
        public int autoID { get;}

        /// <summary>
        /// Print all OrderItem's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
    Order item details:\n
    ID code: {autoID}
    Product barkode: {ProductID}, 
    Order number: {OrderID}, 
    Price: {ProductPrice},
   	Amount in order: {Amount}";
    }
}
