﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        /// <summary>
        /// Order ID
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// The name of the orderer
        /// </summary>
        public string CustomerName { get; }
        /// <summary>
        /// The email of the orderer
        /// </summary>
        public string CustomerEmail { get; }
        /// <summary>
        /// The Address of the orderer
        /// </summary>
        public string CustomerAddress { get; }
        /// <summary>
        /// Date of the order
        /// </summary>
        public DateTime OrderDate { get; }
        /// <summary>
        /// Date of the ship
        /// </summary>
        public DateTime ShipDate { get; }
        /// <summary>
        /// Date of the delivery
        /// </summary>
        public DateTime DeliveryDate { get; }

        public override string ToString() => $@"
    Order details:\n
    Order number: {ID}, 
    Name of the order: {CustomerName},
    address: {CustomerAddress}
    Order date: {OrderDate}";
    }
}