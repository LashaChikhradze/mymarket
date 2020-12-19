using online_CS_N15.Abstraction.Models;
using online_CS_N15.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Services
{
    public class UserService : IUserService
    {
        public Func<string, IUser, IOrder> GetOrderFromUserFunc { get; set; }
        public IOrder SearchForProduct(string productName, IUser userWhoOrdered)
        {
            return GetOrderFromUserFunc.Invoke(productName, userWhoOrdered);
        }
    }
}
