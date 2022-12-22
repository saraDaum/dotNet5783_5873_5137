
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class ProductForList
{
    /// <summary>
    /// Product_For_List unique ID
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Product_For_List name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Item price
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Item category
    /// </summary>
    public DO.Category Category { get; set; }

    public override string ToString() => $@"
    Product_For_List details:\n
    {nameof(ID)}: {ID},
    {nameof(Name)}:{Name},
    {nameof(Price)}: {Price},
    {nameof(Category)}:{Category}";
}

