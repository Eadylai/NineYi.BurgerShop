using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.Breads;
using NineYi.BurgerShop.Veggies;
using NineYi.BurgerShop.Meats;

namespace NineYi.BurgerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. 使用者點餐
            Log.LogAdapter.Log("Which shop do you like? (1)Taipei (2)NewYork: ");
            int shopChoice = int.Parse(Console.ReadLine());

            Log.LogAdapter.Log("What burger would you like? (1)Chicken (2)Pork: ");
            int burgerChoice = int.Parse(Console.ReadLine());

            //// 2. 準備漢堡
            Burger burger = null;
            string shopName = "Taipei";
            string burgerName = "Chicken";
            if (shopChoice == 2)
            {
                shopName = "NewYork";
            }
            if (burgerChoice == 2)
            {
                burgerName = "Pork";
            }

            using (Factory.BurgerFactory burgerFactory = new Factory.BurgerFactory())
            {
                Log.LogAdapter.Log("");
                Log.LogAdapter.Log("Please!Wait!!");
                Log.LogAdapter.Log("");
                burger = burgerFactory.GetBurger(shopName, burgerName);
                burger.Cook();
            }

            Log.LogAdapter.Log("");
            Log.LogAdapter.Log("Press Any Key To Exit...!");
            Console.ReadLine();
        }
    }
}
