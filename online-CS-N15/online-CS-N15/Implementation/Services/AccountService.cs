using online_CS_N15.Abstraction.Models;
using online_CS_N15.Abstraction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Services
{
    public class AccountService : IAccountService
    {
        public void SellProductToUser(IOrder order)
        {
            order.AccountWhoGotOrder.AllProducts.Remove(order.OrderedProduct);
            order.UserWhoOrdered.Products.Add(order.OrderedProduct);
            order.AccountWhoGotOrder.Money += order.OrderedProduct.Price;
            order.UserWhoOrdered.Money -= order.OrderedProduct.Price;
        }
    }
}
