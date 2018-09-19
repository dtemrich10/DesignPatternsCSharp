using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public class DownHill : AbstractMountainBike 
    {
        public DownHill() : this(BikeColor.Red)
        {

        }
        public DownHill(BikeColor color) : base(color)
        {

        }
    }
}
