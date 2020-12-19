using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Models
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gmail { get; set; }
        public double Money { get; set; }
        public List<IProduct> AllProducts { get; set; }
    }
}
