using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshopsolution_data.entitys
{
   public class ProductInCategory
    {
        public int ProductId { get; set; }

        public product Product { get; set; }

        public int CategoryId { get; set; }

        public Categorycs Category { get; set; }
    }
}
