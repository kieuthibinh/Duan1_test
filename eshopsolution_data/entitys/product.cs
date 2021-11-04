using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshopsolution_data.entitys
{
    public class product
    {
        private int id { set; get; }
        private decimal price { set; get; }
        private decimal originalprice { set; get; }
        private int stock { set; get; }
        private int ViewCount { set; get; }
        private DateTime DateCreated { set; get; }
        private string SeoAlias { set; get; }

    }
}
