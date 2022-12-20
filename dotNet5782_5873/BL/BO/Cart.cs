using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public  class Cart
    {/// <summary>
     /// The customer name 
     /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// The customer email 
        /// </summary>
        public string CustomerEmail { get; set; }
        /// <summary>
        /// The customer address 
        /// </summary>
        public string CustomerAddress { get; set; }
        /// <summary>
        /// An item in cart
        /// </summary>
        public List<DO.OrderItem> Item { get; set; }
        /// <summary>
        /// The Total price of customer cart
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Print all cart's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
     Cart details:\n
    {CustomerName} - {CustomerAddress}:
    {nameof(CustomerEmail)}:{CustomerEmail}
    {nameof(Item)}: {Item},
    {nameof(TotalPrice)}: {TotalPrice}";
    }
}
