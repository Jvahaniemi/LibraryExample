using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLibrary
{
    class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
