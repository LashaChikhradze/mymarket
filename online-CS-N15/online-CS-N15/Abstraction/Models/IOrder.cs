using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Models
{
    public interface IOrder
    {
        IUser UserWhoOrdered { get; set; }
        IAccount AccountWhoGotOrder { get; set; }
        IProduct OrderedProduct { get; set; }
    }
}
