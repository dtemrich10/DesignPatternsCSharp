using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public abstract class AbstractBike : IBicyle
    {
        private BikeColor _color;

        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public AbstractBike( BikeColor color)
        {
            this._color = color;
        }

        public virtual void Paint(BikeColor color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " Bicycle color is " + _color;
        }

    }
}
