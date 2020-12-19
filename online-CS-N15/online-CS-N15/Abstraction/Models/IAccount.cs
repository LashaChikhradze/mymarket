using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Models
{
    public interface IAccount
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Gmail { get; set; }
        double Money { get; set; }
        List<IProduct> AllProducts { get; set; }
    }
}
