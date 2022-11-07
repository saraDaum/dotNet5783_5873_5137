
namespace DO;

///<summary>
/// Structure for Product:
/// Every product have the details like: product name, product price, product amount in stock ect.
/// </summary>
public struct Product
{
    //Fields
    public int Barcode { get; set; }
    public string ProductName { get; set; }
    public Category Category { get; set; }
    public double ProductPrice { get; set; }
    public int InStock { get; set; }

    //constructor
    public Product(int barcode, string productName, Category category, double price, int stock)
    {
        Barcode = barcode;
        ProductName = productName;
        Category = category;
        ProductPrice = price;
        InStock = stock;
       
    }

    public override string ToString() => $@"
    Product details:\n
    Product barkode: {Barcode}- {ProductName}, 
    category: {Category},
    Price: {ProductPrice},
   	Amount in stock: {InStock}";
}