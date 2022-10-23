using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public Cirkel()
        {
            Radius = 5;
        }
        public override double Area()
        {
            return (3.141) * Math.Pow(Radius, 2);
        }
    }
}

