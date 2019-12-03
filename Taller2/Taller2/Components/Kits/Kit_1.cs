using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.Components.Kits
{
    public class Kit_1 : AComponent
    {
        public Kit_1() : base(0)
        {
            Number = 105;
            Name = "Speaker plus AS";

            Add(new Speaker(1500));
        }
    }
}
