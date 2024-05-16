using Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public double Review { get; set; }
        public bool IsStock { get; set; }
        public ICollection<ProductLang> ProductLangs { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }

    }
}
