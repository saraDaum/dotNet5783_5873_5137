using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
namespace BlImplementation;
internal class ProductItem:IProductItem
{
    private IDal dal= new Dallist();

     BO.ProductItem productitem 
    {


    }
    public int Add (BO.ProductItem MyBOOProductItem)
    {
       // return dal.Add (MyBOOProduct);    
    }

    public int Delete (int ID)
    {
       // return dal.Delete (ID);
    } 
    public BO.ProductItem Get (int Id )
    {

    }
    public int Uptate (BO.ProductItem MyBoOProductItem) 
    {
    
    }
}
