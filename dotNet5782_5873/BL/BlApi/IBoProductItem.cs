using BO;
using DalApi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;
public interface IBoProductItem
{
    IEnumerable<BO.ProductItem> Get(Func<ProductItem, bool> value);
}

