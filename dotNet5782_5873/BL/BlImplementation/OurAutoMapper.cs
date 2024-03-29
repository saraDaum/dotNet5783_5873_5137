﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public class OurAutoMapper
    {

        public MapperConfiguration OrderItemConfiguration = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.OrderItem, DO.OrderItem>()
        .ForMember(b => b.OrderID, option => option.Ignore())
        .ReverseMap()
        );

        public MapperConfiguration OrderConfiguration = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.Order, DO.Order>()
        .ForMember(b => b.ID, a=> a.MapFrom(x=> x.ID))
        .ReverseMap()
        );

        



        public MapperConfiguration ProductConfiguration = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.Product, DO.Product>()
        .ReverseMap()
            );
        public MapperConfiguration ProductItemConfiguration = new MapperConfiguration(cnf =>
       cnf.CreateMap<BO.ProductItem, DO.Product>()
        .ForMember(b=> b.ProductPrice, a=> a.MapFrom(x=> x.Price))
        .ReverseMap()
        .ForMember(b => b.Price, a => a.MapFrom(x => x.ProductPrice))
        .ForMember(b => b.Name, a => a.MapFrom(x => x.ProductName))
        .ForMember(b => b.Amount, a=> a.MapFrom(x=> 1))
        .ForMember(b => b.InStock, a => a.MapFrom(x => x.Amount > 0))

           );

        /*
        MapperConfiguration configurationOrderItem = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.OrderItem, DO.OrderItem>()
        );*/
    }
}
