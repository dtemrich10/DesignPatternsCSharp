using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public abstract class AbstractRodeBike : AbstractBike 
    {
        public AbstractRodeBike(IWheel wheel) : this(wheel, BikeColor.Chrome)
        {

        }
        public AbstractRodeBike(IWheel wheel, BikeColor color) : base(wheel, color)
        {

        }

        public override decimal Price
        {
            get { return 540.00m; }
        }
    }
}
