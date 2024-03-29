﻿namespace DO;

///<summary>
/// Structure for Product:
/// Every product have the details like: product name, product price, product amount in stock ect.
/// </summary>
public struct Product
{
    //Fields
    public int Barcode { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// The category that this product belong to
    /// </summary>
    public Category Category { get; set; }
    public double ProductPrice { get; set; }
    public int Amount { get; set; }
    // public int InStock { get; set; }

    public Product(int b, string n, Category c, double p, int a)
    {
        Barcode = b;
        ProductName = n;
        Category = c;
        ProductPrice = p;
        Amount = a;
    }
    public override string ToString() => $@"
   {ProductName} 
    Category: {Category}
    Price: {ProductPrice}
   	Amount in stock: {Amount}";
}