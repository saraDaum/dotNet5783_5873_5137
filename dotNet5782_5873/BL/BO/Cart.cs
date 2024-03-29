﻿using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    /// <summary>
    /// BoCart class (a logical entity)
    /// Every entity has customer details, list with all items and total price.
    /// </summary>
    public class Cart
    {/// <summary>
     /// The customer name 
     /// </summary>
        public string? CustomerName { get; set; }
        /// <summary>
        /// The customer email 
        /// </summary>
        public string? CustomerEmail { get; set; }
        /// <summary>
        /// The customer address 
        /// </summary>
        public string? CustomerAddress { get ; set; }
        /// <summary>
        /// An item in cart
        /// </summary>
        public List<BO.ProductItem>? ItemsInCart { get; set; }=new List<BO.ProductItem>();
        /// <summary>
        /// The Total price of customer cart
        /// </summary>
        public double TotalPrice { get; set; } = 0;//Remember to ask the teacher if it's O.K
        /// <summary>
        /// Print all cart's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
     Cart details:\n
    {CustomerName} - {CustomerAddress}:
    {nameof(CustomerEmail)}:{CustomerEmail}
    {nameof(ItemsInCart)}: {ItemsInCart},
    {nameof(TotalPrice)}: {TotalPrice}";
    }
}
