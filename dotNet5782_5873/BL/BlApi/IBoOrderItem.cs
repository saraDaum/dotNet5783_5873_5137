using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IBoOrderItem
{
    BO.OrderItem GetById(int id, int orderId);
}
