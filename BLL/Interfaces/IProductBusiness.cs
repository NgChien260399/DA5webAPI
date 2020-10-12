using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IProductBusiness
    {
        bool Create(ProductModel model);
        ProductModel GetDatabyID(string id);
        List<ProductModel> GetDataAll();
        List<ProductModel> GetDataNew();
        List<ProductModel> Search(int pageIndex, int pageSize, out long total, string category_id);
        List<ProductModel> Search1(int pageIndex, int pageSize, out long total, string brand_id);

    }
}
