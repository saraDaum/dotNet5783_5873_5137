using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using BlApi;
using System.Runtime.InteropServices;
using System.Data.Common;
using AutoMapper;
using BO;

namespace BlImplementation;

internal class BoCart : IBoCart
{
    IDal? dal = DalApi.Factory.Get();
    OurAutoMapper AutoMapper = new OurAutoMapper();


    /// <summary>
    /// This function addes items to cart
    /// </summary>
    /// <param name="cart"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public int Add(BO.Cart cart, BO.ProductItem entity)
    {
        //לבדוק אם כבר המוצר כבר קיים ברשימת המוצרים- ואם כן,תוסיף בכמות של המוצר
        if (cart.ItemsInCart.Any(x => x.Barcode == entity.Barcode))
        {
            int index = cart.ItemsInCart.FindIndex(x => x.Barcode == entity.Barcode);
            cart.ItemsInCart[index].Amount += entity.Amount;
        }
        else//תוסיף את המוצר לרשימת המוצרים
        {
            cart.ItemsInCart.Add(entity);
        }
        //בכל מקרה:
        //לעדכן את הTOTAL-PRICE לפי הכמות והמחיר
        cart.TotalPrice += entity.Price * entity.Amount;
        


        ////Update the new amount
        //DO.Product product = dal.Product.GetAnObject(item => item.Barcode == entity.ProductID);
        //IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
        //BO.Product BoProduct = mapper.Map<BO.Product>(product);
        //int quantityRequested = entity.Amount;
        //if (BoProduct.AmountInStock - quantityRequested > 0)
        //{

        //    product.AmountInStock -= quantityRequested;
        //    BoProduct.AmountInStock -= quantityRequested;
        //    dal.Product.Update(product);//Check that it's works
        //    cart.TotalPrice += entity.ProductPrice * entity.Amount;
        //}
        //else
        //{
        //    if (BoProduct.AmountInStock <= 0)
        //        throw new Exception("This product has been out of stock.");
        //    else
        //        throw new Exception("The requested quantity of this product is not available");
        //}

        return 0;

    }


    /// <summary>
    /// This function clear the customer cart
    /// </summary>
    /// <param name="cartEntity"></param>
    public void Delete(Cart cart, ProductItem entity)
    {
        //לבדוק את המוצר קיים ברשימה ולמחוק אם כן
        if(cart.ItemsInCart.Any(x => x.Barcode == entity.Barcode))
        {
            cart.ItemsInCart.Remove(entity);
            //לעדכן כמות
            cart.TotalPrice -= entity.Price * entity.Amount;
        }
    }

    //Remember to ask the teacher how to do it
    /// <summary>
    /// This function return all cart's datails. All items in cart and total price.
    /// </summary>
    /// <param name="myCart"></param>
    /// <returns></returns>
    //public Tuple<List<BO.OrderItem>, double> Get(Cart myCart)
    //{
    //    int length = myCart.ItemsInCart.Count();
    //    List<BO.OrderItem> allItemsInCart = new List<BO.OrderItem>();
    //    if (length > 0)
    //    {
    //        IMapper mapper = AutoMapper.OrderItemConfiguration.CreateMapper();
    //        allItemsInCart = myCart.ItemsInCart.ConvertAll(item => mapper.Map<BO.OrderItem>(item));
    //    }
    //    return Tuple.Create(allItemsInCart, myCart.TotalPrice);
    //}
    public List<BO.ProductItem> GetAll(BO.Cart cart)
    {
        return cart.ItemsInCart.ToList();
    }
    public void ChangeAmount(Cart cart, int id, int amount)//Why ID?
    {
        if(amount >= 0)
        {
            if(cart.ItemsInCart.Any(x=> x.Barcode == id))
            {
                int index = cart.ItemsInCart.FindIndex(x=> x.Barcode == id);
                cart.TotalPrice -= cart.ItemsInCart[index].Amount * cart.ItemsInCart[index].Price;
                cart.ItemsInCart[index].Amount = amount;
                cart.TotalPrice += amount * cart.ItemsInCart[index].Price;

            }
        }
    }

}
