using online_CS_N15.Abstraction.Enums;
using online_CS_N15.Abstraction.Models;
using online_CS_N15.Abstraction.Services;
using online_CS_N15.Implementation.Models;
using online_CS_N15.Implementation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_CS_N15
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount Lasha = new Account()
            {
                Name = "Lasha",
                Surname = "Chikhradze",
                Money = 0,
                Gmail = "Chikhradzelg@gmail.com",
                AllProducts = new List<IProduct>()
                {
                    new Product()
                    {
                        Name = "Basketball ball",
                        Price = 29.99,
                        State = ProductState.New,
                        CategoryName = ProductCategories.Sport
                    },
                    new Product()
                    {
                        Name = "Guitar",
                        Price = 200,
                        State = ProductState.Used,
                        CategoryName = ProductCategories.Music
                    }
                }
            };
            IAccount Luka = new Account()
            {
                Name = "Luka",
                Surname = "Chikhradze",
                Money = 0,
                Gmail = "Lukenzinio@gmail.com",
                AllProducts = new List<IProduct>()
                {
                    new Product()
                    {
                        Name = "Toy",
                        Price = 19.99,
                        State = ProductState.New,
                        CategoryName = ProductCategories.Kids
                    },
                    new Product()
                    {
                        Name = "Iphone",
                        Price = 1000,
                        State = ProductState.Used,
                        CategoryName = ProductCategories.Technic
                    }
                }
            };

            IUser Guest = new User()
            {
                Name = "Guest",
                Surname = "Unknown",
                Money = 2000,
            };

            IMarketService marketService = new MarketService();
            IUserService userService = new UserService();
            IAccountService accountService = new AccountService();

            userService.GetOrderFromUserFunc = marketService.SearchForProduct;

            marketService.AddAccounts(Lasha);
            marketService.AddAccounts(Luka);

            var Order = userService.SearchForProduct("Iphone", Guest);

            accountService.SellProductToUser(Order);

            Console.WriteLine();
        }
    }
}
