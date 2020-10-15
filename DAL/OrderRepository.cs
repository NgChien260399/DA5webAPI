using DAL.Helper;
using DAL.Helper.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial class OrderRepository : IOrderRepository
    {
        private IDatabaseHelper _dbHelper;
        public OrderRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public bool Create(OrderModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_hoa_don_create",
                "@ma_hoa_don", model.ma_hoa_don,
                "@ho_ten", model.ho_ten,
                "@dia_chi", model.dia_chi,
                "@sdt", model.sdt,
                "@order_total", model.order_total,
                "@listjson_chitiet", model.listjson_chitiet != null ? MessageConvert.SerializeObject(model.listjson_chitiet) : null);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
