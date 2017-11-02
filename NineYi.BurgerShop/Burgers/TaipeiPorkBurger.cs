using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Burgers
{
    /// <summary>
    /// 台北豬肉堡
    /// </summary>
    public class TaipeiPorkBurger : Burger
    {
        public TaipeiPorkBurger()
        {
            this.Name = "Taipei Pork Burger";
            this.Bread = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Breads.WhiteBread") as Breads.Bread;
            this.Veggie = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Veggies.Tomato") as Veggies.Veggie;
            this.Meat = Factory.MaterialFactory.Factory.GetMaterial("NineYi.BurgerShop.Meats.Tenderloin") as Meats.Meat;
        }
    }
}
