using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class OrderBusiness : IOrderBusiness
    {
        private IOrderRepository _res;
        public OrderBusiness(IOrderRepository res)
        {
            _res = res;
        }
        public bool Create(OrderModel model)
        {
            return _res.Create(model);
        }
    }

}
