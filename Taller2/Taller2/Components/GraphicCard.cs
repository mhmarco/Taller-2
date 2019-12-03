using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    /// <summary>
    /// Graphic Card Component
    /// </summary>
    /// 
    /// @Author Marco Morales
    public class GraphicCard : AComponent
    {
        public GraphicCard(double price) : base(price)
        {
            Number = 102;
            Name = "Tarjeta gráfica";
            ExpectedRequiredtime = 5;
        }
    }
}
