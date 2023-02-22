using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    /// <summary>
    /// OrderItem class (a logical entity)
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Product barcde in OrderItem
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Order number in OrderItem
        /// </summary>
        public int OrderID { get; set; }

        /// <summary>
        /// Product price in OrderItem
        /// </summary>
        public double ProductPrice { get; set; }

        /// <summary>
        /// The requested quantity of the product
        /// </summary>
        public int Amount { get; set;}
            

        /// <summary>
        /// Auto ID for this OrderItem
        /// </summary>
        public int autoID { get; set; }

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
