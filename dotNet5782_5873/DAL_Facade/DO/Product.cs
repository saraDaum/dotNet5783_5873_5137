namespace DO;

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
    public int InStock { get; set; }
    public int AmountInStock { get; set; }

    public Product(int b, string n, Category c, double p, int i, int a)
    {
        Barcode = b;
        ProductName = n;    
        Category = c;
        ProductPrice = p;
        ProductPrice = i;
        ProductPrice = a;
    }
    public override string ToString() => $@"
    {nameof(Barcode)}- {ProductName}, 
    category: {Category},
    Price: {ProductPrice},
   	Amount in stock: {InStock}";
}