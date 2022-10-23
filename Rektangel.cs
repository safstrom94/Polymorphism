using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Rektangel : Geometri
    {
        public double heihgt { get; set; }
        public double width { get; set; }
        public Rektangel()
        {
            heihgt = 3;
            width = 6;
        }
        public override double Area()
        {
            return heihgt * width;
        }
    }
}
