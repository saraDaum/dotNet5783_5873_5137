﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalApi;
using BlApi;
using System.Runtime.InteropServices;
using DAL;

namespace BlImplementation;

internal class BoCart:IBoCart
{
    private IDal dal= new DalList();
   // IAutoMapper MyAutoMapper = new AutoMapper();
     public int Add(BO.Cart MyBoCart)
    {

        IBoMapper boMapper;//= MyAutoMapper.Order;
        return 0;
     
    }
    public void Delete(int ID)
    {
         
    }
    
    public BO.Order Get (int Id)
    {
        return null;
    }

    public IEnumerable<BO.Cart> GetAll()
    {
        throw new NotImplementedException();
    }

    public BO.Cart GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(BO.Order MyBoCart)
    {

    }

    public void Update(BO.Cart entity)
    {
        throw new NotImplementedException();
    }
}
