using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Components;

namespace Taller2.ProductsFactory
{
    public class ProductsConcreteFactory : IFactory
    {
        private static ProductsConcreteFactory _instance;

        public static ProductsConcreteFactory Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ProductsConcreteFactory();
                }

                return _instance;
            }
        }

        private ProductsConcreteFactory() { 
}
        public AComponent CreateComponent(EnumComponents component)
        {
            switch(component)
            {
                case EnumComponents.SPEAKER:
                    return new Speaker(1500);

                case EnumComponents.GRAPHIC_CARD:
                    return new Speaker(17000);

                case EnumComponents.PHONE_CAMERA:
                    return new Speaker(5000);

                case EnumComponents.PHONE_SCREEN:
                    return new Speaker(6000);

                case EnumComponents.BATTERY:
                    return new Speaker(7500);

                default:
                    throw new Exception("El componente no existe");
                    
            }
        }
    }
}
