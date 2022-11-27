using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class Cart
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
        public OrderItem item { get; set; }
        /// <summary>
        /// The TotalPrice of cart
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Print all cart's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
     Cart:\n
    {CustomerName} - {CustomerAddress}:
    email:{CustomerEmail}
    Product: {item},
    Total: {TotalPrice}";
    }
}
