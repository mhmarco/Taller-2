using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    /// <summary>
    /// Speaker Component
    /// </summary>
    /// 
    /// @Author Marco Morales
    public class Speaker : AComponent
    {
        public Speaker(double price) : base(price)
        {
            Number = 103;
            Name = "Graphic Card";
            ExpectedRequiredtime = 2;
        }
    }
}
