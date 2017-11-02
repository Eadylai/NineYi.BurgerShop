using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Burgers
{
    /// <summary>
    /// 紐約香雞堡
    /// </summary>
    public class NewYorkChickenBurger : Burger
    {
        public NewYorkChickenBurger()
        {
            this.Name = "NewYork Chicken Burger";
            this.Bread = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Breads.WheatBread") as Breads.Bread;
            this.Veggie = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Veggies.Onion") as Veggies.Veggie;
            this.Meat = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Meats.Turkey") as Meats.Meat;
        }
    }
}
