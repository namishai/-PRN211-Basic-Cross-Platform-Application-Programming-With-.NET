﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic3
{
    public class Circle : Shape
    {
        public override void Display()
        {
            Console.WriteLine("Display Circle");
        }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}
