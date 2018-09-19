using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public abstract class AbstractRodeBike : AbstractBike 
    {
        public AbstractRodeBike() : this(BikeColor.Chrome)
        {

        }
        public AbstractRodeBike(BikeColor color) : base(color)
        {

        }
    }
}
