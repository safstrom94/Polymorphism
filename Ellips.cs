using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Ellips : Geometri
    {
        public double Radius { get; set; }
        public Ellips()
        {
            Radius = 3;
        }
        public override double Area()
        {
            return (3.141) * Math.Pow(Radius, 2);
        }
    } 
}
