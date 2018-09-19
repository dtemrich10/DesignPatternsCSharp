using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public abstract class AbstractMountainBike : AbstractBike
    {
        public AbstractMountainBike() : this(BikeColor.Black)
        {

        }
        public AbstractMountainBike(BikeColor color) : base(color)
        {

        }
    }
}
