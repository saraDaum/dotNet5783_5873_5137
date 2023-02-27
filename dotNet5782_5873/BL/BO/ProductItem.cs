using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// ProductItem class ( a logical entity)
    /// </summary>
    public class ProductItem
    {
        /// <summary>
        /// Identification number product item
        /// </summary>
        public int Barcode { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Product price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Product category
        /// </summary>
        public DO.Category Category { get; set; }
        /// <summary>
        /// Amount of product items
        /// </summary>
        public int Amount { get; set; }
        /// <summary>
        /// Amount in stock
        /// </summary>
        public bool InStock { get; set; }

        public  List<ProductItem> ProductItemList = new List<ProductItem>();


        /// <summary>
        /// Print all ProductItem's details
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $@"

    {nameof(Barcode)}: {Barcode}
    {nameof(Name)}: {Name}
    {nameof(Category)}: {Category}
    Price per product: {Price}
   	Amount to order: {Amount}"
  ;
    }
}
