﻿using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class ProductItem
    {
        /// <summary>
        /// Identification number product item
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Product category
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Amount of product items
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// Amount in stock
        /// </summary>
        public bool InStock { get; set; }
        /// <summary>
        /// Print all ProductItem's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
    Product item details:\n
    ID product: {ID}
    Product name: {Name},
    Product category:{Category}
    Price: {Price},
   	Amount in order: {Amount},
   	Amount in stock: {InStock}";
    }
}