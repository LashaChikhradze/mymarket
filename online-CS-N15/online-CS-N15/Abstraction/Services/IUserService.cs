using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Services
{
    interface IUserService
    {
        //Send order to market
        //Buy Product from account
        Func<string, IUser, IOrder> GetOrderFromUserFunc { get; set; }

        IOrder SearchForProduct(string productName, IUser userWhoOrdered);
    }
}
