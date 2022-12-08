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
        /// Unique ID of OrderOfList
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

        /// <summary>
        /// Print all order for list's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
    OrderForList details:\n
    Order number: {ID}, 
    {nameof(CustomerName)}: {CustomerName},
    {nameof(Status)}: {Status}
    Amount: {AmountOfItems},
    Total:{TotalPrice}";
    }
}
