using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlApi;
using BO;
using DalApi;

namespace BlImplementation;
internal class BoProductItem : IBoProductItem
{
    OurAutoMapper AutoMapper = new OurAutoMapper();
    public IDal? dalVar = DalApi.Factory.Get();
    BlApi.IBl bl = BlApi.Factory.Get();


    private object deligate;

    //We don't implement it yet because we don't know what to do.
    //We wait to see the rest of the instructions.



    IEnumerable<ProductItem>? IBoProductItem.Get(Func<ProductItem, bool> value)
    {
        IEnumerable<DO.Product>? allDoProducts = dalVar.Product.Get(item => item.Barcode == item.Barcode);//A stopid condition to get all items
        IEnumerable<BO.ProductItem>? productItemsList;
        IMapper mapper = AutoMapper.ProductItemConfiguration.CreateMapper();
        productItemsList = allDoProducts.Select(item => mapper.Map<ProductItem>(item));
        productItemsList =productItemsList.Where(value); // (IEnumerable<ProductItem>)
        return productItemsList;
    }


}
