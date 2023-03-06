using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlApi;
using BO;
using DalApi;

namespace BlImplementation;

internal class BoProduct : IBoProduct
{
    IDal? dal = DalApi.Factory.Get();
    OurAutoMapper AutoMapper = new OurAutoMapper();
    IEnumerable<DO.Product> DoProducts = new List<DO.Product>();
    public int Add(Product entity)
    {

        try
        {
            if (entity.ProductPrice > 0 & entity.AmountInStock > 0 & entity.Barcode > 0 & entity.ProductName != null)
            {
                IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
                DO.Product DoProduct = mapper.Map<DO.Product>(entity);
                int Barcode = dal.Product.Add(DoProduct);

                return Barcode;



            }
            else
                throw new Exception();//A way to get exception details
        }
        catch (Exception ex)
        {

            throw new BO.InvalidEntityException("Sorry, the product has not been added.\nSome details seem to be missing", ex);
        }

    }

    public void Delete(int id)
    {

        dal.Product.Delete(id);
    }

    public IEnumerable<Product>? Get(Func<Product, bool> deligate)
    {
        if (deligate != null)
        {
            try
            {
                IEnumerable<Product> BoProduct = new List<Product>();
                IEnumerable<DO.Product>? DoProducts = dal.Product.Get(item => item.Barcode == item.Barcode);//Returns all products from DAL
                IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
                BoProduct = DoProducts.Select(item => mapper.Map<BO.Product>(item));
                return BoProduct.Where(deligate);//Filter
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return null;
    }


    public Product GetAnObject(Predicate<Product> myDelegate)
    {
        throw new NotImplementedException();
    }

    public void Update(Product MyBoProduct)
    {
        try
        {
            if (MyBoProduct.ProductPrice > 0 & MyBoProduct.AmountInStock > 0 & MyBoProduct.Barcode > 0 & MyBoProduct.ProductName != null)
            {
                IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
                DO.Product DoProduct = mapper.Map<BO.Product, DO.Product>(MyBoProduct);
                dal.Product.Update(DoProduct);
            }
           
           
        }
        catch (Exception ex)
        {
            throw new BO.InvalidEntityException("Sorry, the product has not been added.\nSome details seem to be missing", ex);
        }
    }
}



