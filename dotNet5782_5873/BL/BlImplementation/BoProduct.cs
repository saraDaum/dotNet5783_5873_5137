using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BlImplementation;

internal class BoProduct:IBoProduct
{
   private IDal dal= new Dallist();
    BLAutoMapper myMapper = new BLAutoMapper();
    BO.Product product
    {


    }
    public int Add (BO.Product MyBOOProduct)
    {
       // return dal.Add (MyBOOProduct);    
    }

    public int Delete (int ID)
    {
       // return dal.Delete (ID);
    } 
    public BO.Product Get (int Id )
    {

    }
    public int Uptate (BO.Product MyBoOProduct) 
    {
    
    }
     
}



