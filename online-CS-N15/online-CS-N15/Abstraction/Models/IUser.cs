using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Models
{
    public interface IUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        double Money { get; set; }
        List<IProduct> Products { get; set; }
    }
}
