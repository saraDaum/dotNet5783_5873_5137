using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class Cart
    {/// <summary>
     /// The customerName in cart
     /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// The cstomerEmail in cart
        /// </summary>
        public string CustomerEmail { get; set; }
        /// <summary>
        /// The CustomerAddress in cart
        /// </summary>
        public string CustomerAddress { get; set; }
        /// <summary>
        /// The item of cart
        /// </summary>
        public OrderItem item { get; set; }
        /// <summary>
        /// The TotalPrice of cart
        /// </summary>
        public double TotalPrice { get; set; }  
    }
}
