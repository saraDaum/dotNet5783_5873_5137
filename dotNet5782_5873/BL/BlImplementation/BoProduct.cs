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

internal class BoProduct:IBoProduct
{
   private IDal dal= new DalList();
    OurAutoMapper AutoMapper= new OurAutoMapper();
    public int Add(Product entity)
    {
        IMapper mapper = AutoMapper.ProductConfiguration.CreateMapper();
        DO.Product DoProduct= mapper.Map<DO.Product>(entity);
        int Barcode = dal.Product.Add(DoProduct);
        return Barcode;
    }

    public void Delete(int id)
    {
        dal.Product.Delete(id);
    }

    public IEnumerable<Product>? Get(Func<Product, bool>? deligate)
    {
        throw new NotImplementedException();
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



