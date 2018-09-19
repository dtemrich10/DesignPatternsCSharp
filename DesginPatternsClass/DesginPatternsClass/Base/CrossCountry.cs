using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass.Base
{
    class CrossCountry : AbstractMountainBike 
    {
        public CrossCountry() : this(BikeColor.Red)
        {

        }
        public CrossCountry(BikeColor color) : base(color)
        {

        }

    }
}
