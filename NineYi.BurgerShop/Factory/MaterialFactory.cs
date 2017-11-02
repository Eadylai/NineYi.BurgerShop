using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.Factory
{
    public class MaterialFactory
    {
        private static MaterialFactory _Instance = null;

        private MaterialFactory()
        {

        }

        public static MaterialFactory Factory
        {
            get
            {
                if (_Instance == null)
                    _Instance = new MaterialFactory();
                return _Instance;
            }
        }

        public IMaterial GetMaterial(string MaterialName)
        {
            Type MaterialType = Type.GetType(MaterialName);
            IMaterial ResultMaterial = System.Activator.CreateInstance(MaterialType) as IMaterial;
            return ResultMaterial;
        }
    }
}
