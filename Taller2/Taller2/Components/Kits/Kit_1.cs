using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.ProductsFactory;

namespace Taller2.Components.Kits
{
    public class Kit_1 : AComponent
    {
        public Kit_1() : base(0)
        {
            Number = 105;
            Name = "Cámara de teléfono más batería";

            Add(ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.PHONE_CAMERA));
            Add(ProductsConcreteFactory.Instance.CreateComponent(EnumComponents.BATTERY));
        }
    }
}
