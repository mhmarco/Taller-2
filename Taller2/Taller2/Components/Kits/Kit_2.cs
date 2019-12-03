using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.ProductsFactory;

namespace Taller2.Components.Kits
{
    class Kit_2 : BaseKit
    {
        public Kit_2()
        {
            Number = 107;
            Name = "Kit Gamer";

            Add(ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.GRAPHIC_CARD));
            Add(ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.PHONE_SCREEN));
        }

        public override double GetPrice()
        {
            return base.GetPrice();
        }
    }
}
