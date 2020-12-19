using online_CS_N15.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Abstraction.Services
{
    interface IAccountService
    {
        //Get order from market 
        //Sell product to user
        void SellProductToUser(IOrder order);
    }
}
