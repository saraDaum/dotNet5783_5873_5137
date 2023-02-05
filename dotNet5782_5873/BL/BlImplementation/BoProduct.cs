using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlApi;
using BO;
using DAL;
using DalApi;

namespace BlImplementation;

internal class BoProduct : IBoProduct
{
    private IDal dal = new DalList();
    OurAutoMapper AutoMapper = new OurAutoMapper();
    public int Add(Product entity)
    {
        IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
        DO.Product DoProduct = mapper.Map<DO.Product>(entity);
        int Barcode = dal.Product.Add(DoProduct);
        return Barcode;
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
                IEnumerable<DO.Product>? DoProducts = dal.Product.Get(item => item.Barcode == item.Barcode);
                IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
                foreach (DO.Product DoProduct in DoProducts)
                {
                    Product MyProduct = mapper.Map<Product>(DoProduct);
                    BoProduct.Append(MyProduct);
                }
                return BoProduct;
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

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}



