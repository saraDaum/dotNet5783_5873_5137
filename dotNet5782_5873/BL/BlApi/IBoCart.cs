using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IBoCart //: ICrud<BO.Cart>
    {
        public void Add(BO.Cart cart, BO.ProductItem entity);
        public void Delete(BO.Cart cart, BO.ProductItem entity);
        public List<BO.ProductItem> GetAll(BO.Cart cart);
        public void ChangeAmount(BO.Cart cart, int id, int amount);

    }
}
