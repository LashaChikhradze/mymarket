using online_CS_N15.Abstraction.Enums;
using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Models
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public ProductCategories CategoryName { get; set; }
        public double Price { get; set; }
        public ProductState State { get; set; }
    }
}
