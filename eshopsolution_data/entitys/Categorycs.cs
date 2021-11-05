using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshopsolution_data.Enum;

namespace eshopsolution_data.entitys
{
    public class Categorycs
    {
        public int id { get; set; }
        public int SortOrder { get; set; }
        public bool Isshowhome { get; set; }
        public int? ParenId { get; set; }
        public Status status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
