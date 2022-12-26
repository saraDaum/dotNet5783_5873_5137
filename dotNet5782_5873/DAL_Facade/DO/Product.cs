namespace DO;

///<summary>
/// Structure for Product ( a data entity)
/// Every product have the details like: product name, product price, product amount in stock ect.
/// </summary>
public struct Product
{

    /// <summary>
    /// Product barcode (unique number)
    /// </summary>
    public int Barcode { get; set; }

    /// <summary>
    /// Product name
    /// </summary>
    public string ProductName { get; set; }

    /// <summary>
    /// The category that this product belong to
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Product price
    /// </summary>
    public double ProductPrice { get; set; }

    /// <summary>
    /// Amount in stock from this product
    /// </summary>
    public int InStock { get; set; }

    
    public override string ToString() => $@"
    Product details:\n
    {nameof(Barcode)}- {ProductName}, 
    category: {Category},
    Price: {ProductPrice},
   	Amount in stock: {InStock}";
}