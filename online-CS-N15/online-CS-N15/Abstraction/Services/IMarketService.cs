using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Services
{
    public interface IMarketService
    {
        void AddAccounts(IAccount account);
        IOrder SearchForProduct(string productName, IUser userWhoOrdered);
        // Get order From User
        // Send order to Account
    }
}
