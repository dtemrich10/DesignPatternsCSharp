using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public class Vintage : AbstractRodeBike
    {
        public Vintage() : this(BikeColor.Blue)
        {

        }
        public Vintage(BikeColor color) : base(color)
        {

        }
    }
}
