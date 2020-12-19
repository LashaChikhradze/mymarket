using online_CS_N15.Abstraction.Models;
using online_CS_N15.Abstraction.Services;
using online_CS_N15.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15.Implementation.Services
{
    public class MarketService:IMarketService
    {
        private List<IAccount> _allAccounts = new List<IAccount>();

        public void AddAccounts(IAccount account)
        {
            _allAccounts.Add(account);
        }

        public IOrder SearchForProduct(string productName, IUser userWhoOrdered)
        {
            IOrder tmp = null;
            foreach(var item in _allAccounts)
            {
                foreach(var prod in item.AllProducts)
                {
                    if (prod.Name == productName)
                    {
                        tmp = new Order()
                        {
                            UserWhoOrdered = userWhoOrdered,
                            AccountWhoGotOrder = item,
                            OrderedProduct = prod
                        };
                        return tmp;
                    }
                }
            }
            return null;
        }
    }
}
