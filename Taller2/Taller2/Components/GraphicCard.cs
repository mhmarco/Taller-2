using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    public class GraphicCard : AComponent
    {
        public GraphicCard(double price) : base(price)
        {
            Number = 102;
            Name = "Graphic Card";
            ExpectedRequiredtime = 5;
        }
    }
}
