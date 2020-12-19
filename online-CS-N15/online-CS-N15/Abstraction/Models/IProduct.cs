using online_CS_N15.Abstraction.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Models
{
    public interface IProduct
    {
        string Name { get; set; }
        ProductCategories CategoryName { get; set; }
        double Price { get; set; }
        ProductState State { get; set; }
    }
}
