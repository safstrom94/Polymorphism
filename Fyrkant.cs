using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Fyrkant : Geometri
    {
        public double Base { get; set; }

        public Fyrkant()
        {
            Base = 6;
        }
        public override double Area()
        {
            return Math.Pow(Base, 2);
        }
    }
}
