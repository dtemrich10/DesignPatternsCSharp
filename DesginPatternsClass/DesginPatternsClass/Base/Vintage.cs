﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public class Vintage : AbstractRodeBike
    {
        public Vintage(IWheel wheel) : this(wheel, BikeColor.Blue)
        {

        }
        public Vintage(IWheel wheel, BikeColor color) : base(wheel, color)
        {

        }

        public override decimal Price
        {
            get { return 600.00m; }
        }
    }
}
