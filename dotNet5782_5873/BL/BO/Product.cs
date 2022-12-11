using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        /// <summary>
        /// Product barcode (identification number)
        /// </summary>
        public int Barcode { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Product category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public double ProductPrice { get; set; }

        /// <summary>
        /// Amount in stock
        /// </summary>
        public int InStock { get; set; }

        /// <summary>
        /// Print all product's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
    Product details:\n
    {nameof{Barcode}-} {ProductName}, 
    {nameof{category}:} {Category},
    {nameof{Price}:} {ProductPrice},
   	{nameof{Amount in stock}:} {InStock}";

    }
}

