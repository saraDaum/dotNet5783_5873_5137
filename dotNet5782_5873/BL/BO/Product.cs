using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    ///<summary>
    /// BO_Product class (a logical entity)
    /// Every entity have the details like: product name,product category, product price, product amount in stock ect.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product barcode (identification number)
        /// </summary>
        public int Barcode { get; set; }//It is not null. Product must have a barcode.

        /// <summary>
        /// Product name
        /// </summary>
        public string? ProductName { get; set; }

        /// <summary>
        /// Product category
        /// </summary>
        public DO.Category Category { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public double ProductPrice { get; set; }

        /// <summary>
        /// Amount in stock
        /// </summary>
        public int AmountInStock { get; set; }

        /// <summary>
        /// Print all product's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"
   
    {ProductName} 
    {nameof(Category)}: {Category}
    {nameof(ProductPrice)} :{ProductPrice}
   	{nameof(AmountInStock)} :{AmountInStock}";

    }
}

