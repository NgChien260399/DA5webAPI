using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class ProductBusiness : IProductBusiness
    {
        private IProductRepository _res;
        public ProductBusiness(IProductRepository CategoryRes)
        {
            _res = CategoryRes;
        }
        public bool Create(ProductModel model)
        {
            return _res.Create(model);
        }
        public bool Delete(string id)
        {
            return _res.Delete(id);
        }
        public bool Update(ProductModel model)
        {
            return _res.Update(model);
        }
        public List<ProductModel> Search(int pageIndex, int pageSize, out long total, string product_name, decimal product_price)
        {
            return _res.Search(pageIndex, pageSize, out total, product_name, product_price);
        }
        public ProductModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<ProductModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
        public List<ProductModel> GetDataNew()
        {
            return _res.GetDataNew();
        }
        public List<ProductModel> SearchCategory(int pageIndex, int pageSize, out long total, string category_id)
        {
            return _res.SearchCategory(pageIndex, pageSize, out total, category_id);
        }
        public List<ProductModel> SearchBrand(int pageIndex, int pageSize, out long total, string brand_id)
        {
            return _res.SearchBrand(pageIndex, pageSize, out total, brand_id);
        }
    }

}
