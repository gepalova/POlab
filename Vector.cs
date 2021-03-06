﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Vector
    {

        public double x;
        public double y;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Mi Air, 08.03.2020. </remarks>
        ///
        /// <param name="x">    The x coordinate. </param>
        /// <param name="y">    The y coordinate. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Length => Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
    }
}
