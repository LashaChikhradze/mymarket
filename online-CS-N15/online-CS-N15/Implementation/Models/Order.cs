using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Models
{
    public class Order : IOrder
    {
        public IUser UserWhoOrdered { get; set; }
        public IAccount AccountWhoGotOrder { get; set; }
        public IProduct OrderedProduct { get; set; }
    }
}
