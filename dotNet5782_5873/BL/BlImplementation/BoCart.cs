using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using BlApi;
using System.Runtime.InteropServices;

namespace BlImplementation;

internal class BoCart:IBoCart
{
    private IDal dal= new Dallist();

     public int Add(BO.Cart MyBoCart)
    {
      
     
    }
    public void Delete(int ID)
    {

    }
    
    public BO.Order Get (int Id)
    {

    }
    
    public void Update(BO.Order MyBoCart)
    {

    }
}
