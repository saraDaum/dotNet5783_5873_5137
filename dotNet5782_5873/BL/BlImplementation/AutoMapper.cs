using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    public class OurAutoMapper
    {

        MapperConfiguration configurationOredr = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.BOOrder, DO.Order>()
        .ForMember(b => b.ID, option => option.MapFrom(b => b.ID))
        .ForMember(b => b.CustomerName, option => option.MapFrom(d => d.CustomerName))
        .ForMember(b => b.CustomerEmail, option => option.MapFrom(d => d.CustomerEmail))
        .ForMember(b => b.CustomerAddress, option => option.MapFrom(d => d.CustomerAddress))
        .ForMember(b => b.OrderDate, option => option.MapFrom(d => d.OrderDate))
        .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.ShipDate))
        .ForMember(b => b.DeliveryDate, option => option.MapFrom(d => d.DeliveryDate))
        .ReverseMap()
        .ForMember(b => b.ID, option => option.MapFrom(b => b.ID))
        .ForMember(b => b.CustomerName, option => option.MapFrom(d => d.CustomerName))
        .ForMember(b => b.CustomerEmail, option => option.MapFrom(d => d.CustomerEmail))
        .ForMember(b => b.CustomerAddress, option => option.MapFrom(d => d.CustomerAddress))
        .ForMember(b => b.OrderDate, option => option.MapFrom(d => d.OrderDate))
        .ForMember(b => b.ShipDate, option => option.MapFrom(d => d.ShipDate))
        .ForMember(b => b.DeliveryDate, option => option.MapFrom(d => d.DeliveryDate))
        .ForMember(b => b.Status, option => option.Ignore())
        .ForMember(b => b.AmountOfItems, option => option.Ignore())
        .ForMember(b => b.TotalPrice, option => option.Ignore())

        );


        MapperConfiguration configurationOrderItem = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.BOOrderItem, DO.OrderItem>()
        );

        MapperConfiguration configurationProduct = new MapperConfiguration(cnf =>
        cnf.CreateMap<BO.BOProduct, DO.Product()>
        );

    }
}
