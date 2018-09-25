﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesginPatternsClass
{
    public class DownHill : AbstractMountainBike 
    {
        public DownHill(IWheel wheel) : this(wheel, BikeColor.Red)
        {

        }
        public DownHill(IWheel wheel, BikeColor color) : base(wheel, color)
        {

        }

        public override decimal Price
        {
            get { return 870.00m; }
        }

    }
}
