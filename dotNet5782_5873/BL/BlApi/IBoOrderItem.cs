using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IBoOrderItem:ICrud<BO.OrderItem>
{
    BO.OrderItem GetById(int id, int orderId);
}
