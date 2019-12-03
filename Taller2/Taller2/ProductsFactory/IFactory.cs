using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2.Components;

namespace Taller2.ProductsFactory
{
    /// <summary>
    /// Interface of factory pattern.
    /// </summary>
    /// 
    /// @Author Jose Ulloa
    /// @Author Marco Morales
    public interface IFactory
    {
        AComponent CreateComponent(EnumComponents component);
    }
}
