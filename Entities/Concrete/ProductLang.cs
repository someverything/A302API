using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProductLang : BaseEntity
    {
        public string Name { get; set; }
        public string LangCode { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public decimal Discount { get; set; }

    }
}
