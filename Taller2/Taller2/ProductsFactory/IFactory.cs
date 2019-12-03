using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Components;

namespace Taller2.ProductsFactory
{
    public interface IFactory
    {
        AComponent CreateComponent(EnumComponents component);
    }
}
