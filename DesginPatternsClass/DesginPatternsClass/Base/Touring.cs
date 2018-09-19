using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public class Touring : AbstractRodeBike 
    {
        public Touring() : this(BikeColor.Blue)
        {

        }
        public Touring(BikeColor color) : base(color)
        {

        }
    }
}
