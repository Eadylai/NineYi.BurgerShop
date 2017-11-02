using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public class BurgerFactory : IDisposable
    {
        public void Dispose()
        {

        }

        public Burgers.Burger GetBurger(string shopName, string burgerName)
        {
            Type BurgerType = Type.GetType("NineYi.BurgerShop.Burgers." + shopName + burgerName + "Burger");
            Burgers.Burger Burger = System.Activator.CreateInstance(BurgerType) as Burgers.Burger;
            return Burger;
        }
    }
}
