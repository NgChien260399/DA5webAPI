using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderBusiness _OrderBusiness;
        public OrderController(IOrderBusiness OrderBusiness)
        {
            _OrderBusiness = OrderBusiness;
        }

        [Route("create-order")]
        [HttpPost]
        public OrderModel CreateItem([FromBody] OrderModel model)
        {
            model.ma_hoa_don = Guid.NewGuid().ToString();
            if (model.listjson_chitiet != null)
            {
                foreach (var item in model.listjson_chitiet)
                    item.ma_chi_tiet = Guid.NewGuid().ToString();
            }
            _OrderBusiness.Create(model);
            return model;
        }
    }
}
