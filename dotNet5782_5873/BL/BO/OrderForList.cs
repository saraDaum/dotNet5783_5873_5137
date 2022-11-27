using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class OrderForList
    {
        /// <summary>
        /// Id of OrderOfList
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Customer name
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// Order status 
        /// </summary>
        public OrderStatus Status { get; set; }
        /// <summary>
        /// Amount of Items
        /// </summary>
        public int AmountOfItems { get; set; }
        /// <summary>
        /// Total price
        /// </summary>
        public double TotalPrice { get; set; }
    }
}
