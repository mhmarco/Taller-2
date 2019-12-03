using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    /// <summary>
    /// Battery Component for fix
    /// </summary>
    /// 
    /// @Author Marco Morales
    class Battery : AComponent
    {
        public Battery(double price) : base(price)
        {
            Number = 104;
            Name = "Batería";
            ExpectedRequiredtime = 2;
        }
    }
}
