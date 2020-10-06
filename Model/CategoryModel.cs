using System;
using System.Collections.Generic;

namespace Model
{
	public class CategoryModel
	{
        public string parent_category_id { get; set; }
        public string category_id { get; set; }
        public string category_name { get; set; }
        public string seq_num { get; set; }
        public short? url { get; set; }
        public List<CategoryModel> children { get; set; }
        public string type { get; set; }
    }
}
