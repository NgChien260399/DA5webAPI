﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface IBrandRepository
    {
        List<BrandModel> GetData();
        BrandModel GetDatabyID(string id);
        bool Create(BrandModel model);
        bool Update(BrandModel model);
        bool Delete(string id);
        List<BrandModel> Search(int pageIndex, int pageSize, out long total, string brand_name);
    }
}
