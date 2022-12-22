using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using BlApi;
using System.Runtime.InteropServices;
using DAL;
using System.Data.Common;
using AutoMapper;
using BO;

namespace BlImplementation;

internal class BoCart : IBoCart
{
    private IDal dal = new DalList();
    OurAutoMapper AutoMapper = new OurAutoMapper();


    /// <summary>
    /// This function addes items to cart
    /// </summary>
    /// <param name="cart"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Add(BO.Cart cart, BO.OrderItem entity)
    {
        //Update the new amount
        DO.Product product = dal.Product.GetAll().First(item => item.Barcode == entity.ProductID);
        IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
        BO.Product BoProduct = mapper.Map<BO.Product>(product);
        int quantityRequested = entity.Amount;
        if (BoProduct.AmountInStock - quantityRequested > 0)
        {

            product.InStock -= quantityRequested;
            BoProduct.AmountInStock -= quantityRequested;
            dal.Product.Update(product);//Check that it's works
            cart.TotalPrice+= entity.ProductPrice*entity.Amount;
        }
        else
        {
            if (BoProduct.AmountInStock <= 0)
                throw new Exception("This product has been out of stock.");
            else
                throw new Exception("The requested quantity of this product is not available");
        }

        return 0;

    }
    

    /// <summary>
    /// This function clear the customer cart
    /// </summary>
    /// <param name="cartEntity"></param>
    public void Delete(Cart cartEntity)
    {
        cartEntity.ItemsInCart.Clear();
        cartEntity.TotalPrice = 0;

    }

    //Remember to ask the teacher how to do it
    /// <summary>
    /// This function return all cart's datails. All items in cart and total price.
    /// </summary>
    /// <param name="myCart"></param>
    /// <returns></returns>
    public Tuple<List<BO.OrderItem>,double> Get(Cart myCart)
    {
        int length = myCart.ItemsInCart.Count();
        List<BO.OrderItem> allItemsInCart = new List<BO.OrderItem>();
        if (length > 0)
        {
            IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
            allItemsInCart = myCart.ItemsInCart.ConvertAll(item => mapper.Map<BO.OrderItem>(item));
        }
        return Tuple.Create( allItemsInCart, myCart.TotalPrice);
    }



}
