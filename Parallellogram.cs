using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Parallellogram : Geometri
    {
        public double heihgt { get; set; }
        public double width { get; set; }
        public Parallellogram()
        {
            heihgt = 2;
            width = 3;
        }
        public override double Area()
        {
            return heihgt * width;
        }
    }
}
