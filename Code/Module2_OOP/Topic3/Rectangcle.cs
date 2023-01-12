﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic3
{
    internal class Rectangcle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("Display Rectangle");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }

        public new void Print()
        {
            Console.WriteLine("Print Rectangle");
        }
    }
}
