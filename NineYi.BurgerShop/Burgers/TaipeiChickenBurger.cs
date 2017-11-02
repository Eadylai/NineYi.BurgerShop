using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Burgers
{
    /// <summary>
    /// 台北香雞堡
    /// </summary>
    public class TaipeiChickenBurger : Burger
    {
        public TaipeiChickenBurger()
        {
            this.Name = "Taipei Chicken Burger";
            this.Bread = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Breads.WhiteBread") as Breads.Bread;
            this.Veggie = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Veggies.Tomato") as Veggies.Veggie;
            this.Meat = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Meats.TaiwanChicken") as Meats.Meat;
        }
    }
}
