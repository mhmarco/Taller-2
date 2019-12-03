using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components
{
    class Battery : AComponent
    {
        public Battery(double price) : base(price)
        {
            Number = 104;
            Name = "Battery";
            ExpectedRequiredtime = 2;

        }
    }
}
